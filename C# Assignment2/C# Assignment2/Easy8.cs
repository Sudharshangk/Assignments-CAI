using System;
class PatternPrint
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        DisplayRightAngleTriangle(rows);
    }
    static void DisplayRightAngleTriangle(int rows)
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}