//1
//2 3
//4 5 6
//7 8 9 10
//11 12 13 14 15

using System;
class Numberpattern3
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        DisplayIncrementedNumberTriangle(rows);
    }
    static void DisplayIncrementedNumberTriangle(int rows)
    {
        int count = 1;
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(count++ + " ");
            }
            Console.WriteLine();
        }
    }
}