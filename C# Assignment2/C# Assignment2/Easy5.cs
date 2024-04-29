//Write a program that returns the n-th word from a string. The “#” is a delimiter in the string. 
//Please note the example:
//String = “Deep#sea#fishing#is#a#dangerous#occupation#because#of#the#rough#sea#”

using System;
class NthWord
{
    static void Main(string[] args)
    {
        string inputString = "Deep#sea#fishing#is#a#dangerous#occupation#because#of#the#rough#sea#";
        Console.WriteLine("Enter the value of n:");
        int n = Convert.ToInt32(Console.ReadLine());
        string nthWord = GetNthWord(inputString, n);
        Console.WriteLine($"The {n}-th word in the string is: {nthWord}");
    }
    static string GetNthWord(string inputString, int n)
    {
        string[] words = inputString.Split('#');
        if (n >= 1 && n <= words.Length)
        {
            return words[n - 1];
        }
        else
        {
            return "Invalid input";
        }
    }
}

