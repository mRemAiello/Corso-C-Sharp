using System;

public class ConsoleView
{
    public virtual void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public virtual string? GetUserInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    public virtual void DisplayUsers(IEnumerable<User> users)
    {
        Console.WriteLine("\nUser List:");
        foreach (var user in users)
        {
            Console.WriteLine(user);
        }
    }
}