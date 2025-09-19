class Program
{
    static void Main(string[] args)
    {
        // Write a C# program that prompts the user to input two numbers and divides them. 
        // Handle an exception when the user enters non-numeric values.

        bool validInput = false;
        while (!validInput)
        {
            try
            {
                Console.Write("Enter the first number: ");
                string? input1 = Console.ReadLine();
                double num1 = Convert.ToDouble(input1);

                Console.Write("Enter the second number: ");
                string? input2 = Console.ReadLine();
                double num2 = Convert.ToDouble(input2);

                if (num2 == 0)
                {
                    throw new DivideByZeroException();
                }

                double result = num1 / num2;
                Console.WriteLine($"The result of {num1} divided by {num2} is {result}");

                validInput = true; // Exit the loop if successful
            }
            catch (FormatException)
            {
                validInput = false;
                Console.WriteLine("Error: Please enter valid numeric values.");
            }
            catch (DivideByZeroException)
            {
                validInput = false;
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (Exception ex)
            {
                validInput = false;
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        Console.WriteLine("Program has ended.");
    }
}