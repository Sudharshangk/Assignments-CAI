using System;
class WordCount
{
    static void Main(string[] args)
    {
        string sentence = "A tiger is a large-hearted gentleman with boundless courage";
        int wordCount = CountWords(sentence);
        Console.WriteLine($"Number of words in the sentence: {wordCount}");
    }
    static int CountWords(string sentence)
    {
        int wordCount = 0;
        bool inWord = false;
        foreach (char c in sentence)
        {
            if (char.IsLetter(c))
            {
                if (!inWord)
                {
                    wordCount++;
                    inWord = true;
                }
            }
            else
            {
                inWord = false;
            }
        }
        return wordCount;
    }
}