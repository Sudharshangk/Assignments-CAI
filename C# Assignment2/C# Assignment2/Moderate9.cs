using System;
class NumberOfDigits
{
    static void Main(string[] args)
    {
        Console.WriteLine(num_of_digits(1000)); // Output: 4
        Console.WriteLine(num_of_digits(12));   // Output: 2
    }
    static int num_of_digits(int num)
    {
        if (num == 0)
        {
            return 1;
        }
        int count = 0;
        while (num != 0)
        {
            num /= 10;
            count++;
        }
        return count;
    }
}