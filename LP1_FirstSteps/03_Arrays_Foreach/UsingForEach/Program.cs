/*
~ Using the "foreach" Statement ~
& 8/14/21 &
* - Use foreach to iterate through each element in an array, executing the associated code block once for each element in the array.
* - sets the value of the current element in the array to a temporary variable, for use within code block.
*/
using System;

namespace UsingForEach
{
    class Program
    {
        static void Main()
        {
            //int[] inventory = new int[5] { 200, 450, 700, 175, 250 };
            int[] inventory = { 200, 450, 700, 175, 250 };
            int sum = 0;
            int bin = 0;
            foreach (int item in inventory)
            {
                sum += item; //! Increments sum by item per loop.
                bin++; //! Increments value by 1. Same as "bin = bin + 1".
                Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");
            }
            Console.WriteLine($"We have {sum} items in inventory.");
        }
    }
}
