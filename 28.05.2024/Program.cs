using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
     
        var fruits = new Dictionary<string, int>()
        {
            { "apple", 5 },
            { "mango", 15 },
            { "orange", 8 },
            { "banan", 20 },
            { "peach", 3 }
        };

        Console.WriteLine("Исходный словарь:");
        Print(fruits);

        List<string> removeFruit = new List<string>();
        foreach (var fruit in fruits)
        {
            if (fruit.Value < 10)
                removeFruit.Add(fruit.Key);
        }

        foreach (var i in removeFruit)
        {
            fruits.Remove(i);
        }

        Console.WriteLine("Измененный словарь:");
        Print(fruits);
    }

    static void Print(Dictionary<string, int> dict)
    {
        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
