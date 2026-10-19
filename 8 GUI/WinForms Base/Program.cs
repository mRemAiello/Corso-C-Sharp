namespace WinFormsBase;

public static class Program
{
    [STAThread]
    private static void Main()
    {
        UserPreferencesForm mainForm = new();
        // controller = new Controller(mainForm);

        ApplicationConfiguration.Initialize();
        Application.Run(mainForm);
    }
}