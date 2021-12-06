/*
! Challenge: Fix this Code !

~   - Fix the poorly-written code below and ensure it provides the expected response to complete the challenge!
^   - There are many potential improvements you can make!

?           CODE TO FIX:            ?
*           int[] numbers = { 4, 8, 15, 16, 23, 42 };
*           foreach (int number in numbers)
*           {
*               int total;
*               total += number;
*               if (number == 42)
*               {
*                  bool found = true;
*               }
*           }
*           if (found)
*           {
*               Console.WriteLine("Set contains 42");
*           }
*           Console.WriteLine($"Total: {total}");

&           EXPECTED RESULT:            ?
?               - Set contains 42
?               - Total: 108
*/
using System;

namespace Challenge_CodeFix
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            int total = 0;
            bool found = false;
            foreach (int number in numbers) //^ Common expression using curly-braces, indentation, and code-blocks.
            {
                total += number;
                if (number == 42) found = true;
            }
            if (found) Console.WriteLine("Set contains 42"); //^ Shortened expression without curly-braces, indentation, or code-blocks whatsoever.
            Console.WriteLine($"Total: {total}");
        }
    }
}
