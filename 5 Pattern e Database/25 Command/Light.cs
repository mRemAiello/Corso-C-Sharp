using System;

namespace PatternEDatabase.Command;

public class Light
{
    private readonly string _location;
    private bool _isOn;

    public Light(string location)
    {
        _location = location;
    }

    public void Accendi()
    {
        if (_isOn)
        {
            Console.WriteLine($"La luce {_location} è già accesa.");
            return;
        }

        _isOn = true;
        Console.WriteLine($"La luce {_location} si accende.");
    }

    public void Spegni()
    {
        if (!_isOn)
        {
            Console.WriteLine($"La luce {_location} è già spenta.");
            return;
        }

        _isOn = false;
        Console.WriteLine($"La luce {_location} si spegne.");
    }
}
