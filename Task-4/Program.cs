namespace Task_4;

using System;

class Program
{
    static void Main()
    {
        // Create an integer array with 5 favorite numbers
        int[] numbers = { 25, 10, 50, 15, 30 };

        // Sort the array in ascending order
        Array.Sort(numbers);

        Console.WriteLine("Sorted Array:");

        // Print sorted array
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // Reverse the sorted array
        Array.Reverse(numbers);

        Console.WriteLine("\nReversed Array:");

        // Print reversed array
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // Find the position of a specific number
        int searchNumber = 30;
        int position = Array.IndexOf(numbers, searchNumber);

        Console.WriteLine("\nPosition of " + searchNumber + ": " + position);
    }
}