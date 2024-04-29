using System;
class PrimeFactors
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number to find its prime factors: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Prime Factors of " + number + " = ");
        FindPrimeFactors(number);
    }
    static void FindPrimeFactors(int number)
    {
        // Start with the smallest prime factor, which is 2
        int divisor = 2;
        while (number > 1)
        {
            // Check if the current divisor divides the number evenly
            if (number % divisor == 0)
            {
                Console.Write(divisor);
                // Reduce the number by dividing it by the divisor
                number /= divisor;
                // If the number is still divisible by the divisor, keep dividing
                while (number % divisor == 0)
                {
                    Console.Write("x" + divisor);
                    number /= divisor;
                }
            }
            // Move to the next divisor
            divisor++;
        }
    }
}