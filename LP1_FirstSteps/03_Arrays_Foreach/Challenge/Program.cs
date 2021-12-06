/*
~ MS C# "Arrays" Module Challenge Exercise ~
& 8/14/21 &

        ~   _The Setup_   ~
?   - Previously, we set out to write code that would store Order IDs belonging to potentially fraudulent orders.
?   - Our hope is to find fraudulent orders as early as possible and flag them for deeper analysis.
?   - Our team found a pattern. Orders that start with the letter "B" encounter fraud 25 times the normal rate.
?   - We will write new code that will output the Order ID of new orders where the Order ID starts with the letter "B".
?   - This will be used by our fraud team to investigate further.
        *   _Step 1_   *
*   - Create array with fake order ids.
! Here's the fake Order ID data to use for array:
?   B123   C234   A345   C15   B177   G3003   C235   B179
        *   _Step 2_   *
*   - Iterate through each element of the array.
        ^ - Use a foreach loop.
        *   _Step 3_   *
*   - If Order ID starts with a "B":
        * - Print ID to output.
        ! Output should be:
        * B123
        * B177
        * B179
*/
using System;
namespace Challenge
{
    class Program
    {
        static void Main()
        {
            string[] fakeOrderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
            int count = 0;
            Console.WriteLine("\nPossibly-Faked Order IDs:");
            foreach (string orderID in fakeOrderIDs)
            {
                if (orderID.StartsWith("B"))
                {
                    count++;
                    Console.WriteLine($"\n{count}. {orderID}");
                }
            }
        }
    }
}
