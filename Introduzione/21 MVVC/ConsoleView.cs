using System;

public class ConsoleView
{
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public string GetUserInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    public void DisplayUsers(IEnumerable<User> users)
    {
        Console.WriteLine("\nUser List:");
        foreach (var user in users)
        {
            Console.WriteLine(user);
        }
    }
}