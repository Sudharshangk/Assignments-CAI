using System;
public class NthWord
{
    static string StrNthWord(string str, int n)
    {
        string[] strings = str.Split('#');
        return strings[n - 1];
    }
    static void Main(string[] args)
    {
        string str = "Deep#sea#fishing#is#a#dangerous#occupation#because#of#the#rough#sea";
        Console.WriteLine(StrNthWord(str, 6));
    }
}