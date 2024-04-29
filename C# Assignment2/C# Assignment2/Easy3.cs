using System;
class ReverseProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string inputString = Console.ReadLine();
        string reversedString = ReverseString(inputString);
        Console.WriteLine($"Reversed string: {reversedString}");
    }
    static string ReverseString(string inputString)
    {
        char[] charArray = inputString.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}