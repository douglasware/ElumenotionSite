using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Example usage
        List<string> items = new List<string> { 
            // the first 20 letters of the alphabet
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t"
        };
        Dictionary<string, int> Counts = new Dictionary<string, int>(); 

        for(int i = 0; i < 1000; i++)
        {
            string selectedItem = WeightedRandomSelection.SelectItem(items, .5F, .8F, 6);
            Counts[selectedItem] = (Counts.ContainsKey(selectedItem) ? Counts[selectedItem] + 1: 0);
        }
        foreach(var item in items)
        {
            if (Counts.ContainsKey(item))
            {
                Console.WriteLine($"{item} {Counts[item]}");
            }
        }
    }
}
