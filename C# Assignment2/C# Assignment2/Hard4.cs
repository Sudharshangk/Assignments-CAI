//Write a program in C# Sharp to count the number of digits in a number using recursion. 
//Test Data:
//Input any number: 12345
//Expected Output:
//The number 12345 contains the number of digits: 5

using System;
class NumberOfDigitsInInputRecurssion
{
    static void Main(string[] args)
    {
        Console.Write("Input any number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int digitCount = CountDigits(number);
        Console.WriteLine("The number " + number + " contains the number of digits: " + digitCount);
    }
    static int CountDigits(int number)
    {
        if (number < 10)
        {
            return 1;
        }
        else
        {
            return 1 + CountDigits(number / 10);
        }
    }
}