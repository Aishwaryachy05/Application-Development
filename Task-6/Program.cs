namespace Task_6;

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a List containing 3 favorite fruits
        List<string> fruits = new List<string>
        {
            "Apple",
            "Mango",
            "Banana"
        };

        // Add a new fruit
        fruits.Add("Orange");

        // Remove one fruit
        fruits.Remove("Banana");

        // Print all fruits using foreach
        Console.WriteLine("Fruits in the List:");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Create a Dictionary with fruit IDs and names
        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
        {
            { 1, "Apple" },
            { 2, "Mango" },
            { 3, "Banana" }
        };

        // Add a new entry
        fruitDictionary.Add(4, "Orange");

        // Print all key-value pairs
        Console.WriteLine("\nFruit Dictionary:");

        foreach (KeyValuePair<int, string> item in fruitDictionary)
        {
            Console.WriteLine("ID: " + item.Key + ", Fruit: " + item.Value);
        }
    }
}