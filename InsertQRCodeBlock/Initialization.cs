[assembly: ExtensionApplication(typeof(InsertQRCodeBlock.Initialization))]

namespace InsertQRCodeBlock;

internal class Initialization : IExtensionApplication
{
    public void Initialize()
    {
        Acaop.Idle += OnIdle;
    }

    private static void OnIdle(object sender, EventArgs e)
    {
        var doc = Acaop.DocumentManager.MdiActiveDocument;
        if (doc == null)
            return;
        Acaop.Idle -= OnIdle;
        try
        {
            doc.Editor.WriteMessage("\nInsertQRCodeBlock loaded.\n");
        }
        catch (System.Exception ex)
        {
            doc.Editor.WriteMessage($"\nError: {ex.Message}\n");
        }
    }

    public void Terminate() { }
}
