class Program
{
    static void Main(string[] args)
    {
        // Write a C# program to implement a method that takes an integer as input and throws an exception if the number is negative. 
        // Handle the exception in the calling code. 

        bool validInput = false;
        while (!validInput)
        {
            try
            {
                Console.WriteLine("Enter a number:");
                string? value = Console.ReadLine();
                int number = Convert.ToInt32(value);
                CheckPositive(number);
                Console.WriteLine("The number is positive.");

                validInput = true; // Exit the loop if input is valid
            }
            catch (ArgumentException ex)
            {
                validInput = false;
                Console.WriteLine($"Exception caught: {ex.Message}");
            }
        }
    }

    static void CheckPositive(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("The number cannot be negative.");
        }
    }
}