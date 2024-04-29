//Allow the user to enter a number, and display the place 
//value for each digit as units, tens, hundreds, etc. for example note the following examples:
//Input Number: 8453
//Output: 8000
//Output: 400
//Out Output: 50
//Out Output: 3

using System;
class ValueOfTheDigits
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        DisplayPlaceValue(number);
    }
    static void DisplayPlaceValue(int number)
    {
        int divisor = 1;
        while (number > 0)
        {
            int digit = number % 10;
            int placeValue = digit * divisor;
            Console.WriteLine("Output: " + placeValue);
            divisor *= 10;
            number /= 10;
        }
    }
}