using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input the size of array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[size];
        Console.WriteLine($"Input {size} elements in the array in ascending order:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"element - {i} : ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Input the position where to delete: ");
        int position = Convert.ToInt32(Console.ReadLine());
        DeleteElementAtPosition(ref array, ref size, position);
        Console.WriteLine("The new list is: ");
        foreach (int element in array)
        {
            Console.Write($"{element} ");
        }
    }
    static void DeleteElementAtPosition(ref int[] array, ref int size, int position)
    {
        if (position < 0 || position >= size)
        {
            Console.WriteLine("Invalid position.");
            return;
        }
        for (int i = position; i < size - 1; i++)
        {
            array[i] = array[i + 1];
        }
        size--;
    }
}