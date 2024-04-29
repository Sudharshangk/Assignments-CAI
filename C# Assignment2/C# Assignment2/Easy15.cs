//Covert or switch the following alphabets to upper case or lower case.
//So if the alphabet is in uppercase convert it to lowercase and visa-versa. 
//Do not use the Isupper or Islower method, instead, 
//you have to use the ASCII value to convert for uppercase or lowercase. 
//Note the following is a famous line by Jim Corbett:
//Input character:   "TiGer Is A LaRgE-HeArTeD GentlEmAN witH BounDleSS CouRAgE"
//Output character: "tIgER iS a lArGe-hEaRtEd ....."

using System;
class UpperAndLower
{
    static void Main(string[] args)
    {
        string inputString = "TiGer Is A LaRgE-HeArTeD GentlEmAN witH BounDleSS CouRAgE";
        string outputString = ConvertCase(inputString);
        Console.WriteLine("Input character:   " + inputString);
        Console.WriteLine("Output character:  " + outputString);
    }
    static string ConvertCase(string input)
    {
        char[] result = new char[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            // Convert uppercase to lowercase
            if (c >= 'A' && c <= 'Z')
            {
                result[i] = (char)(c + 32);
            }
            // Convert lowercase to uppercase
            else if (c >= 'a' && c <= 'z')
            {
                result[i] = (char)(c - 32);
            }
            // Preserve non-alphabetic characters
            else
            {
                result[i] = c;
            }
        }
        return new string(result);
    }
}