//Write a C# Sharp program to find the middle character(s) of a given string. 
//Return the middle character if the length of the string is odd and return two
//middle characters if the length of the string is even.

using System;

class MiddleCharacter
{
    static void Main(string[] args)

    {
        Console.WriteLine("Enter a String");
        string str = Console.ReadLine();
        int len = str.Length;
        int res = len / 2;
        if (len % 2 == 0)
        {
            Console.Write(str[res - 1]);
            Console.Write(str[res]);
        }
        else
        {
            Console.Write(str[res]);
        }
    }
}