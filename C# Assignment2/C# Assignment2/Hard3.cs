//Write a program in C# Sharp to display the individual digits of a given number using recursion.
//Test Data:
//Input any number: 1234
//Expected Output:
//The digits in the number 1234 are: 1 2 3 4

using System;
class IndividualDigits
{
    static void Main(string[] args)
    {
        Console.Write("Input any number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write("The digits in the number " + number + " are: ");
        DisplayDigits(number);
        Console.WriteLine();
    }
    static void DisplayDigits(int number)
    {
        if (number < 10)
        {
            Console.Write(number + " ");
        }
        else
        {
            DisplayDigits(number / 10);
            Console.Write(number % 10 + " ");
        }
    }
}