[assembly: CommandClass(typeof(InsertQRCodeBlock.Commands))]

namespace InsertQRCodeBlock;

public class Commands
{
    [CommandMethod(nameof(QrCodeInsert))]
    public static void QrCodeInsert()
    {
        var doc = Acaop.DocumentManager.MdiActiveDocument;
        var db = doc.Database;
        var ed = doc.Editor;
        var layers = GetLayers(db, out string clayer);
        using var dialog = new QrCodeBlockDialog(layers, clayer);
        var dialogResult = Acap.ShowModalDialog(dialog);
        if (dialogResult != DialogResult.OK)
            return;
        try
        {
            using var tr = db.TransactionManager.StartTransaction();
            using var blockTable = (BlockTable)tr.GetObject(db.BlockTableId, OpenMode.ForRead);
            if (blockTable.Has(dialog.BlockName))
            {
                ed.WriteMessage($"\n错误: 块名 '{dialog.BlockName}' 已经存在.");
                return;
            }
            var coder = new BlockQrCoder(
                dialog.PlainText,
                dialog.EccLevel,
                dialog.ForceUtf8 | dialog.ForceUtf8Bom,
                dialog.ForceUtf8Bom,
                dialog.EciMode,
                dialog.RequestVerion
            )
            {
                BackgroundColor = dialog.BackgroundColor,
                ForegroundColor = dialog.ForegroundColor,
            };
            var btrId = coder.CreateBlock(db, dialog.BlockName, dialog.AddAttribute);
            using (var br = new BlockReference(Point3d.Origin, btrId))
            {
                br.Layer = dialog.Layer;
                br.ScaleFactors = new Scale3d(dialog.BlockScale);
                br.TransformBy(ed.CurrentUserCoordinateSystem);
                var jig = new QrCodeBlockJig(br, "\n指定插入点: ");
                var result = ed.Drag(jig);
                if (result.Status == PromptStatus.OK)
                {
                    using var currentSpace = (BlockTableRecord)
                        tr.GetObject(db.CurrentSpaceId, OpenMode.ForWrite);
                    currentSpace.AppendEntity(br);
                    tr.AddNewlyCreatedDBObject(br, true);
                }
            }
            tr.Commit();
        }
        catch (System.Exception ex)
        {
            ed.WriteMessage($"\nError: {ex.Message}\n{ex.StackTrace}");
        }
    }

    private static List<string> GetLayers(Database db, out string clayer)
    {
        List<string> layers = [];
        clayer = string.Empty;
        using var tr = new OpenCloseTransaction();
        using var layerTable = (LayerTable)tr.GetObject(db.LayerTableId, OpenMode.ForRead);
        foreach (ObjectId id in layerTable)
        {
            using var layer = (LayerTableRecord)tr.GetObject(id, OpenMode.ForRead);
            layers.Add(layer.Name);
            if (id == db.Clayer)
                clayer = layer.Name;
        }

        return layers;
    }

    private class QrCodeBlockJig(BlockReference br, string message) : EntityJig(br)
    {
        private Point3d _dragPoint;

        protected override SamplerStatus Sampler(JigPrompts prompts)
        {
            var result = prompts.AcquirePoint(message);
            if (result.Value.IsEqualTo(_dragPoint))
                return SamplerStatus.NoChange;
            _dragPoint = result.Value;
            return SamplerStatus.OK;
        }

        protected override bool Update()
        {
            br.Position = _dragPoint;
            return true;
        }
    }
}
