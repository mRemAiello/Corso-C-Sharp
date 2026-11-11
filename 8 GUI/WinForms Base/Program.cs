namespace WinFormsBase;

public static class Program
{
    [STAThread]
    private static void Main()
    {
        try
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new UserPreferencesForm());
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.ToString(),
                "Errore avvio applicazione",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}