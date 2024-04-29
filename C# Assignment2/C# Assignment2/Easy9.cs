//Enter the number of rows: 5
//1
//12
//123
//1234
//12345
    
using System;
class NumberPattern1
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        DisplayNumberTriangle(rows);
    }
    static void DisplayNumberTriangle(int rows)
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}
