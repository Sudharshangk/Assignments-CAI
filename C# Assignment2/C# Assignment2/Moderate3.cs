using System;
class UpperToLower
{
    static void Main(string[] args)
    {
        string sentence = "It waS a cOLD AND foggy WintEr MorNiNg, I WenT ouT in SearCH of ElusiVe LEoParD";
        string uppercaseSentence = ConvertToUppercase(sentence);
        Console.WriteLine(uppercaseSentence);
    }
    static string ConvertToUppercase(string sentence)
    {
        char[] chars = sentence.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] >= 'a' && chars[i] <= 'z')
            {
                chars[i] = (char)(chars[i] - 32);
            }
        }
        return new string(chars);
    }
}