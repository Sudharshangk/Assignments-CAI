using System;
class ReverseSentence
{
    static void Main(string[] args)
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();
        string reversedSentence = ReverseWords(input);
        Console.WriteLine("Reversed sentence: " + reversedSentence);
    }
    static string ReverseWords(string sentence)
    {
        string[] words = sentence.Split(' ');
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}
