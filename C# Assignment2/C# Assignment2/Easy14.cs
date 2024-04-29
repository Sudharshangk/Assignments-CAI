using System;
class PrimeNumberRange
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the starting number of the range:");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the ending number of the range:");
        int end = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The prime numbers between {0} and {1} are:", start, end);
        FindPrimeNumbersInRange(start, end);
    }
    static void FindPrimeNumbersInRange(int start, int end)
    {
        for (int num = start; num <= end; num++)
        {
            if (IsPrime(num))
            {
                Console.Write(num + " ");
            }
        }
    }
    static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}