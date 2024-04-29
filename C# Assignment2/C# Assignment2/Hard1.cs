//Let a user enter random alphanumeric characters; 
//write a code in C# to generate the following pattern as shown in the following example. 
//The pattern is an alternate band of characters. The first character entered is to be used as the start of the pattern, your code should terminate once it is not able to create the required pattern. Please note the following examples.
//Enter alphanumeric: g1hpkn6s20
//Pattern: g1h6p2k0n
//Enter alphanumeric: 10R4FDG0N457KL78521
//Pattern: 1R0F4D0G4N5K7L7

using System;
class AlphaNumericChar
{
    static void Main()
    {
        Console.Write("Enter alphanumeric: ");
        string input = Console.ReadLine();
        string pattern = GeneratePattern(input);
        Console.WriteLine("Pattern: " + pattern);
    }
    static string GeneratePattern(string input)
    {
        if (string.IsNullOrEmpty(input))
            return "";
        char startChar = input[0];
        string pattern = startChar.ToString();
        for (int i = 1; i < input.Length; i++)
        {
            if (char.IsDigit(input[i - 1]) && char.IsDigit(input[i]))
            {
                pattern += input[i];
            }
            else if (!char.IsDigit(input[i - 1]) && !char.IsDigit(input[i]))
            {
                pattern += input[i];
            }
        }
        return pattern;
    }
}