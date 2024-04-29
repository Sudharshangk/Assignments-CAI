using System;
using System.Collections.Generic;
class UnrepeartedWords
{
    static void Main(string[] args)
    {
        Console.WriteLine(unrepeated("teshahset")); // Output: "tesha"
        Console.WriteLine(unrepeated("hello"));     // Output: "helo"
        Console.WriteLine(unrepeated("call 911"));  // Output: "cal 91"
    }
    static string unrepeated(string word)
    {
        HashSet<char> seen = new HashSet<char>();
        string result = "";
        foreach (char c in word)
        {
            if (!seen.Contains(c))
            {
                result += c;
                seen.Add(c);
            }
        }
        return result;
    }
}