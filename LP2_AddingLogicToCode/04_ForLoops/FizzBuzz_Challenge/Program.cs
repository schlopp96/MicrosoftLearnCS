/*
& Fizz Buzz Challenge &
& 9/9/21 &

~ FizzBuzz is a popular coding challenge and interview question.
~ It exercises your understanding of:
*   - the `for`
*   - the `if`
*   - the `%` remainder operator
*   - your command of basic logic.

!           FIZZBUZZ RULES              !

! 1. Output values from 1 to 100, one number per line.
! 2. When the current value is divisible by 3, print the term Fizz next to the number.
! 3. When the current value is divisible by 5, print the term Buzz next to the number.
! 4. When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.
*/
using System;

namespace FizzBuzz_Challenge
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i < 10) // Enforce spacing between i and FizzBuzz.
                {
                    if ((i % 3 == 0) && (i % 5 == 0)) Console.WriteLine($"{i}    FizzBuzz");
                    else if (i % 3 == 0) Console.WriteLine($"{i}    Fizz");
                    else if (i % 5 == 0) Console.WriteLine($"{i}    Buzz");
                    else Console.WriteLine(i);
                }
                else if (i >= 100 && i < 1000)
                {
                    if ((i % 3 == 0) && (i % 5 == 0)) Console.WriteLine($"{i}  FizzBuzz");
                    else if (i % 3 == 0) Console.WriteLine($"{i}  Fizz");
                    else if (i % 5 == 0) Console.WriteLine($"{i}  Buzz");
                    else Console.WriteLine(i);
                }
                else if (i == 1000)
                {
                    if ((i % 3 == 0) && (i % 5 == 0)) Console.WriteLine($"{i} FizzBuzz");
                    else if (i % 3 == 0) Console.WriteLine($"{i} Fizz");
                    else if (i % 5 == 0) Console.WriteLine($"{i} Buzz");
                    else Console.WriteLine(i);
                }
                else
                {
                    if ((i % 3 == 0) && (i % 5 == 0)) Console.WriteLine($"{i}   FizzBuzz");
                    else if (i % 3 == 0) Console.WriteLine($"{i}   Fizz");
                    else if (i % 5 == 0) Console.WriteLine($"{i}   Buzz");
                    else Console.WriteLine(i);
                }
            }
        }
    }
}
