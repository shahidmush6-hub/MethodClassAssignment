using System;

// Class containing the method
class MathOperations
{
    // Method that accepts two integer parameters
    public void PerformOperation(int firstNumber, int secondNumber)
    {
        // Add 10 to the first number
        int result = firstNumber + 10;

        // Display the result
        Console.WriteLine("Result after adding 10 to first number: " + result);

        // Display the second number
        Console.WriteLine("Second number: " + secondNumber);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object of MathOperations class
        MathOperations mathObj = new MathOperations();

        // Call method using positional arguments
        mathObj.PerformOperation(5, 20);

        Console.WriteLine();

        // Call method using named arguments
        mathObj.PerformOperation(firstNumber: 10, secondNumber: 30);

        // Keep console window open
        Console.ReadLine();
    }
}