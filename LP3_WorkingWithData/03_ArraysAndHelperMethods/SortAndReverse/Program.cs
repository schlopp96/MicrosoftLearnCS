/*
    < Sort() and Reverse() >
        > 11/22/2021 <

? Suppose you work for a logistics company.
? You've been asked to write code that keeps track of pallets that are filled with building supplies.
? That list of pallets will be reordered.
? How can you maintain such a list?

    @ Use Array Methods to Sort Elements in an Array @

^ The Array class contains methods that we can use to manipulate the content, arrangement, and size of an array.

> In this exercise, you'll write code that performs various operations on an array of pallet identifiers, which may be the start of an application to track and optimize the usage of pallets for the company.

    @ Recap @

^ Here's a few important ideas that we covered in this unit:

    * The Array class has methods that can manipulate the size and contents of an array.
    * Use the Sort() method to manipulate the order based on the given data type of the array.
    * Use the Reverse() method to flip the order of the elements in the array.

*/

Console.Write("Please choose which example you wish to see:\n\n1.) Step 1: Create an array of pallets, then sort them.\n\n2.) Step 2: Perform Step 1, then Reverse the order of the pallets.\n\nEnter anything else to close.\n\t-> ");
var uchoice = Console.ReadLine();
if (uchoice == "1")
{
    Sort();
}
else if (uchoice == "2")
{
    Sort_Reverse();
}
else
{
    Console.WriteLine("\nExiting...");
    Thread.Sleep(2000);
}


static void Sort()
{
    string[] pallets = { "B14", "A11", "B12", "A13" };

    Console.WriteLine("\nCreated list of pallet contents:\n{ \"B14\", \"A11\", \"B12\", \"A13\" }\n\nSorted...\n");
    Array.Sort(pallets); //> Here we're using the Sort() method of the Array class to sort the items in the array alphanumerically.
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"\t|--> {pallet}|");
    }
}

static void Sort_Reverse()
{
    string[] pallets = { "B14", "A11", "B12", "A13" };

    Console.WriteLine("\nCreated list of pallet contents:\n{ \"B14\", \"A11\", \"B12\", \"A13\" }\n\nSorted...\n");
    Array.Sort(pallets);
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"\t|--> {pallet}|");
    }

    Console.WriteLine("");
    Console.WriteLine("Reversed...\n");
    Array.Reverse(pallets); //> Here we're using the Reverse() method of the Array class to reverse the order of the items.
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"\t|--> {pallet}|");
    }
}