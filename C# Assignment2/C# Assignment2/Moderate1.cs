using System;
class XPattern
{
    static void Main(string[] args)
    {
        PrintXPattern("Hello World!!");
    }
    static void PrintXPattern(string text)
    {
        int length = text.Length;
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                if (j == i || j == length - i - 1)
                {
                    Console.Write(text[j]);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            // Add spaces before next line
            for (int k = 0; k < i + 1; k++)
            {
                Console.Write(" ");
            }
        }
    }
}