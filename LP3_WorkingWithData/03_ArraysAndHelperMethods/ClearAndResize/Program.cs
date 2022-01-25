/*
        > Clear() and Resize() <
            ~ 11/28/2021 ~

> As we continue building a pallet tracker for our logistics company, suppose we also need track new pallets and remove old pallets from tracking.
    < How can we accomplish this?

                ^ Array.Clear(): ^
    > allows us to remove the contents of specific elements in our array.

                @ Array.Resize(): @
    ~ adds or removes elements from our array.

                    < Recap >
> Here's a few important ideas that we covered in this unit:

    * Use the Clear() method to empty the values out of elements in the array.
    ! Use the Resize() method to change the number of elements in the array, removing or adding elements from the end of the array.
    ? New array elements and cleared elements are null, meaning they don't point to a value in memory.
*/

static void main()
{
    while (true)
    {

        Console.Write("\nPlease Enter STEP NUMBER for Example You Wish to See:\n=====================================================\n> Step 1: Using `Clear()` to remove items from an array.\n> Step 2: Access Value of Cleared Element\n> Step 3: Call a String Helper Method on a Cleared Element.\n> Step 4: Resize the Array to Add More Elements.\n> Step 5: Resize the Array to Remove Elements.\n> Enter [Exit] to Close Program (case doesn't matter).\n|=> ");
        var uchoice = Console.ReadLine();
        if (uchoice == "1")
        {
            Console.WriteLine("=====================================================\nArray: {\"B14\", \"A11\", \"B12\", \"A13\"}\n");
            Step1();
            Console.WriteLine("\nPress anything to continue...\n");
            Console.ReadKey(true);
        }
        else if (uchoice == "2")
        {
            Console.WriteLine("=====================================================\nArray: {\"B14\", \"A11\", \"B12\", \"A13\"}\n");
            Step2();
            Console.WriteLine("\nPress anything to continue...\n");
            Console.ReadKey(true);
        }
        else if (uchoice == "3")
        {
            Console.WriteLine("=====================================================\nArray: {\"B14\", \"A11\", \"B12\", \"A13\"}\n");
            Step3();
            Console.WriteLine("\nPress anything to continue...\n");
            Console.ReadKey(true);
        }
        else if (uchoice == "4")
        {
            Console.WriteLine("=====================================================\nArray: {\"B14\", \"A11\", \"B12\", \"A13\"}\n");
            Step4();
            Console.WriteLine("\nPress anything to continue...\n");
            Console.ReadKey(true);
        }

        else if (uchoice == "5")
        {
            Console.WriteLine("=====================================================\nArray: {\"B14\", \"A11\", \"B12\", \"A13\"}\n");
            Step5();
            Console.WriteLine("\nPress anything to continue...\n");
            Console.ReadKey(true);
        }
        else if (uchoice is "exit" or "ex" or "Exit")
        {
            Console.WriteLine("\nExiting...");
            Thread.Sleep(750);
            break;
        }
        else
        {
            Console.WriteLine($"\n\nInvalid Input:\n\"{uchoice}\"\nMust only enter the number of step to run, or \"exit\".\n");
            Thread.Sleep(1500);
        }
    }
}

static void Step1()
{
    string[] pallets = { "B14", "A11", "B12", "A13" };


    Console.WriteLine($"Clearing 2 spaces...\nNew count: {pallets.Length}\n");
    Array.Clear(pallets, 0, 2);

    int count = 0;
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"--[{count}] {pallet}");
        count += 1;
    }
}

static void Step2()
{
    string[] pallets = { "B14", "A11", "B12", "A13" };


    Console.WriteLine($"Before: pallets[0] = {pallets[0]}");

    Console.WriteLine($"\nClearing 2 spaces...\nNew count: {pallets.Length}");
    Array.Clear(pallets, 0, 2);

    Console.WriteLine($"\nAfter: pallets[0] = \"{pallets[0]}\"\n");

    int count = 0;
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"--[{count}] {pallet}");
        count += 1;
    }
}

static void Step3()
{
    string[] pallets = { "B14", "A11", "B12", "A13" };


    Console.WriteLine($"Before: pallets[0].ToLower() = {pallets[0].ToLower()}");

    Console.WriteLine($"\nClearing 2 spaces...\nNew count: \"{pallets.Length}\"\n");
    Array.Clear(pallets, 0, 2);

    if (pallets[0] != null)
    {   //< Without this expresion, program would crash due to attempt to call ToLower() on contents of pallets[0] element before Compiler has a chance to implicitly convert null to empty string..
        Console.WriteLine($"\nAfter: pallets[0].ToLower() = \"{pallets[0].ToLower()} \"\n");
    }
    else
    {
        Console.WriteLine($"\nAfter: pallets[0] = {pallets[0]}\n\nNOTE: If pallets[0].ToLower was used after clearing, a crash will occur due to referencing a null value before implicit string conversion.\n");
    }

    int count = 0;
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"--[{count}] {pallet}");
        count += 1;
    }
}

static void Step4()
{
    string[] pallets = { "B14", "A11", "B12", "A13" };


    Console.WriteLine($"Clearing 2 spaces...\n\nNew count: {pallets.Length}\n");
    Array.Clear(pallets, 0, 2);

    int count = 0;
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"--[{count}] {pallet}");
        count += 1;
    }


    Array.Resize(ref pallets, 6);
    Console.WriteLine($"\nResizing array size to 6 elements ...\nNew count: {pallets.Length}\n\nAssigning pallets[4] to = 'C01'\nAssigning pallets[5] to = 'C02'\n");

    pallets[4] = "C01";
    pallets[5] = "C02";
    count = 0;
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"--[{count}] {pallet}");
        count += 1;
    }
}

static void Step5()
{
    string[] pallets = { "B14", "A11", "B12", "A13" };


    Array.Clear(pallets, 0, 2);
    Console.WriteLine($"Clearing 2 spaces...\n\nNew count: {pallets.Length}\n");

    int count = 0;
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"--[{count}] {pallet}");
        count += 1;
    }


    Array.Resize(ref pallets, 6);
    Console.WriteLine($"\nResizing array size to 6 elements ...\nNew count: {pallets.Length}\n\nAssigning pallets[4] to = 'C01'\nAssigning pallets[5] to = 'C02'\n");

    pallets[4] = "C01";
    pallets[5] = "C02";
    count = 0;
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"--[{count}] {pallet}");
        count += 1;
    }


    Array.Resize(ref pallets, 3);
    Console.WriteLine($"\nResizing array size to 3 elements ...\n\nNew count: {pallets.Length}\n");

    count = 0;
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"--[{count}] {pallet}");
        count += 1;
    }
}

main();