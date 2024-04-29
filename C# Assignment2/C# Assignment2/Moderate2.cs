using System;
class FindingDuplicates
{
    static void Main(string[] args)
    {
        int[] sequence = { 1, 2, 3, 3, 4, 5, 5, 6, 6, 7, 8, 9, 9 };
        FindRepeatingNumber(sequence);
    }
    static void FindRepeatingNumber(int[] sequence)
    {
        int n = sequence.Length;
        for (int i = 1; i < n; i++)
        {
            if (sequence[i] == sequence[i - 1])
            {
                Console.WriteLine("Repeating number: " + sequence[i]);
                break;
            }
        }
    }
}