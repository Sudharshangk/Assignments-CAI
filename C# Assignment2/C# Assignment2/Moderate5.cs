using System;
class DaimondPattern
{
    static void Main(string[] args)
    {
        int n = 5; // Change this value to adjust the size of the diamond
        PrintDiamondPattern(n);
    }
    static void PrintDiamondPattern(int n)
    {
        // Print upper half of the diamond
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < 2 * i + 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        // Print lower half of the diamond
        for (int i = n - 2; i >= 0; i--)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < 2 * i + 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}