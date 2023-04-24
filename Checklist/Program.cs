using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        // Create an empty list to hold the checklist items
        List<string> checklist = new List<string>();

        // Prompt the user to enter checklist items, and add them to the list
        Console.WriteLine("Enter checklist items (type 'done' when finished):");
        string input = "";
        while (input != "done")
        {
            input = Console.ReadLine();
            if (input != "done")
            {
                checklist.Add(input);
            }
        }

        // Print out the checklist items
        Console.WriteLine("\nChecklist:");
        for (int i = 0; i < checklist.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + checklist[i]);
        }

        // Prompt the user to mark an item as completed, and update the list
        Console.WriteLine("\nEnter the number of an item to mark as completed (or type 'skip'):");
        input = Console.ReadLine();
        if (input != "skip")
        {
            int index = Int32.Parse(input) - 1;
            checklist[index] = "[X] " + checklist[index];
        }

        // Print out the updated checklist items
        Console.WriteLine("\nUpdated Checklist:");
        for (int i = 0; i < checklist.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + checklist[i]);
        }

        // Prompt the user to remove an item from the list, and update the list
        Console.WriteLine("\nEnter the number of an item to remove (or type 'skip'):");
        input = Console.ReadLine();
        if (input != "skip")
        {
            int index = Int32.Parse(input) - 1;
            checklist.RemoveAt(index);
        }

        // Print out the final checklist items
        Console.WriteLine("\nFinal Checklist:");
        for (int i = 0; i < checklist.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + checklist[i]);
        }
    }
}
