using System;

public class FileView : ConsoleView
{
    public override void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public override string? GetUserInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    public override void DisplayUsers(IEnumerable<User> users)
    {
        Console.WriteLine("\nUser List:");
        foreach (var user in users)
        {
            Console.WriteLine(user);
        }
    }
}