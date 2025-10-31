namespace WinFormsBase;

public static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new UserPreferencesForm());
    }
}