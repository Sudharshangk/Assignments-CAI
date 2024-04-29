using System;
class PermutationCombination
{
    static void Main(string[] args)
    {
        Console.Write("Input the number of elements to store in the array [maximum 5 digits]: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Input " + n + " elements in the array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("element - " + i + " : ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("The Permutations with a combination of " + n + " digits are:");
        Permute(array, 0, n - 1);
    }
    static void Permute(int[] array, int left, int right)
    {
        if (left == right)
        {
            PrintArray(array);
        }
        else
        {
            for (int i = left; i <= right; i++)
            {
                Swap(ref array[left], ref array[i]);
                Permute(array, left + 1, right);
                Swap(ref array[left], ref array[i]); // Backtrack
            }
        }
    }
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item);
        }
        Console.Write(" ");
    }
}