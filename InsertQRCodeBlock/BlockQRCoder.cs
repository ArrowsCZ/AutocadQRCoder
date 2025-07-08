namespace InsertQRCodeBlock;

/// <summary>
/// Error correction code (ECC) level (same as QRCoder.QRCodeGenerator.ECCLevel).
/// </summary>
public enum EccLevel
{
    Default = -1,
    L,
    M,
    Q,
    H,
}

/// <summary>
/// Extended Channel Interpretation (ECI) mode (same as QRCoder.QRCodeGenerator.EciMode).
/// </summary>
public enum EciMode
{
    Default = 0,
    Iso88591 = 3,
    Iso88592 = 4,
    Utf8 = 26,
}

/// <summary>
/// Provides methods to create AutoCAD entities (Hatch or Block) representing a QRCode.
/// Uses QRCOder library (https://github.com/codebude/QRCoder/wiki).
/// </summary>
public class BlockQrCoder
{
    private readonly List<BitArray> _matrix;
    private readonly string _plainText;
    private readonly int _size;

    /// <summary>
    /// Gets or sets the background color.
    /// </summary>
    public Color BackgroundColor { get; set; } = Color.FromRgb(255, 255, 255);

    /// <summary>
    /// Gets or sets the foreground color.
    /// </summary>
    public Color ForegroundColor { get; set; } = Color.FromRgb(0, 0, 0);

    /// <summary>
    /// Creates a new instance of BlockQRCoder (same parameters as QRCodeGenerator.CreateQrCode method).
    /// </summary>
    /// <param name="plainText">Text which shall be encoded in the QR Code.</param>
    /// <param name="eccLevel">Error correction code level. Either L (7%), M (15%), Q (25%) or H (30%).</param>
    /// <param name="forceUtf8">If true, forces text encoding in UTF-8.</param>
    /// <param name="utf8Bom">If true, sets ByteOrderMark (BOM) when BlockQRCoder uses UTF-8 for text-encoding</param>
    /// <param name="eciMode">Fixed ECI mode.</param>
    /// <param name="requestedVersion">Fixed QR code version.</param>
    public BlockQrCoder(
        string plainText,
        EccLevel eccLevel = EccLevel.Default,
        bool forceUtf8 = false,
        bool utf8Bom = false,
        EciMode eciMode = EciMode.Default,
        int requestedVersion = -1
    )
    {
        _plainText = plainText;
        using var qrGenerator = new QRCodeGenerator();
        using QRCodeData qrCodeData = qrGenerator.CreateQrCode(
            plainText,
            (QRCodeGenerator.ECCLevel)eccLevel,
            forceUtf8,
            utf8Bom,
            (QRCodeGenerator.EciMode)eciMode,
            requestedVersion
        );
        _matrix = qrCodeData.ModuleMatrix;
        _size = _matrix.Count;
    }

    /// <summary>
    /// Creates a new block definition.
    /// </summary>
    /// <param name="db">Database to which the block belongs.</param>
    /// <param name="blockName">Name of the block (creates an anonymous block if null).</param>
    /// <param name="plainTextAsAttribute">If true, adds a constant attribute (plain text).</param>
    /// <returns>The objectId of the block definition.</returns>
    /// <exception cref="System.ArgumentException">Thrown if the database already contains a block with the same name.</exception>
    public ObjectId CreateBlock(
        Database db,
        string blockName = null,
        bool plainTextAsAttribute = false
    )
    {
        using var tr = new OpenCloseTransaction();
        if (string.IsNullOrEmpty(blockName))
            blockName = "*U";
        var blockTable = (BlockTable)tr.GetObject(db.BlockTableId, OpenMode.ForRead);

        if (blockTable.Has(blockName))
            throw new ArgumentException($@"{blockName} already exists", nameof(blockName));

        var btr = new BlockTableRecord { Name = blockName };
        tr.GetObject(db.BlockTableId, OpenMode.ForWrite);
        var blockId = blockTable.Add(btr);
        tr.AddNewlyCreatedDBObject(btr, true);

        var solid = GetBackgroundSolid();
        btr.AppendEntity(solid);
        tr.AddNewlyCreatedDBObject(solid, true);

        var hatch = GetHatch();
        btr.AppendEntity(hatch);
        tr.AddNewlyCreatedDBObject(hatch, true);

        if (plainTextAsAttribute)
        {
            var attDef = new AttributeDefinition(
                Point3d.Origin,
                _plainText.Replace("\r\n", "\\P"),
                "TEXT",
                "",
                db.Textstyle
            )
            {
                IsMTextAttributeDefinition = true,
                Constant = true,
                Height = 2.5,
                Justify = AttachmentPoint.TopCenter,
                AlignmentPoint = new Point3d(_size / 2.0, -2.0, 0.0),
            };
            btr.AppendEntity(attDef);
            tr.AddNewlyCreatedDBObject(attDef, true);
        }

        tr.Commit();
        return blockId;
    }

    /// <summary>
    /// Gets a Solid figuring the QR Code background.
    /// </summary>
    /// <returns>the newly created Solid.</returns>
    private Solid GetBackgroundSolid() =>
        new(
            new Point3d(0.0, 0.0, 0.0),
            new Point3d(_size, 0.0, 0.0),
            new Point3d(0.0, _size, 0.0),
            new Point3d(_size, _size, 0.0)
        )
        {
            Color = BackgroundColor,
        };

    /// <summary>
    /// Gets a Hatch figuring the QR Code.
    /// </summary>
    /// <returns>The newly created Hatch.</returns>
    private Hatch GetHatch()
    {
        var hatch = new Hatch();
        for (int i = 0; i < _size; i++)
        {
            for (int j = 0; j < _size; j++)
            {
                if (!_matrix[i][j])
                    continue;
                HatchLoop loop = new(HatchLoopTypes.Polyline);

                double x = i;
                double y = _size - j;

                loop.Polyline.Add(new BulgeVertex(new Point2d(x, y), 0.0));
                loop.Polyline.Add(new BulgeVertex(new Point2d(x + 1.0, y), 0.0));
                loop.Polyline.Add(new BulgeVertex(new Point2d(x + 1.0, y - 1.0), 0.0));
                loop.Polyline.Add(new BulgeVertex(new Point2d(x, y - 1.0), 0.0));
                loop.Polyline.Add(new BulgeVertex(new Point2d(x, y), 0.0));

                hatch.AppendLoop(loop);
            }
        }
        hatch.SetHatchPattern(HatchPatternType.PreDefined, "SOLID");
        hatch.Color = ForegroundColor;
        hatch.EvaluateHatch(true);
        return hatch;
    }
}
