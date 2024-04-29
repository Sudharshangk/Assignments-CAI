//Enter the number of rows: 5
//     *
//    **
//    ***
//    ****
//    *****

using System;
class PyramidPattern
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        DisplayAsteriskPyramid(rows);
    }
    static void DisplayAsteriskPyramid(int rows)
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}