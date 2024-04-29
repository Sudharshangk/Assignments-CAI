//Enter the number of rows: 5
//1
//22
//333
//4444
//55555

using System;
class NumberPattern2
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        DisplayRepeatedNumberTriangle(rows);
    }
    static void DisplayRepeatedNumberTriangle(int rows)
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}