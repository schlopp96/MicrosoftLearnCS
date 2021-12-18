/*
                                ~ Evaluate floating-point types ~
                                        * 10/17/21 *

    $- First, you must also consider the digits of precision each types allow.
        <-> Precision is the number of values that can be stored after the decimal point.

    $- Second, you must consider the manner in which the values are stored and the impact that has on the accuracy of the value.
        <-> In other words, float and double values are stored internally in a binary (base 2) format while decimal is stored in a decimal (base 10) format.

                    ! - Why does this matter?

    $- Performing math on binary floating-point values can produce results that may surprise you if you're used to decimal (base 10) math.
    $- Often, binary floating-point math is an approximation of the real value.
        <- Therefore, float and double are useful because large numbers can be stored using a small memory footprint;
        <-> HOWEVER, should only be used when an approximation is useful.
        <-> For example, being a few thousandths off when calculating the blast zone of a weapon in a video game is close enough.

    $- When you need more a more precise answer, you should use decimal.
        >- Each value of type decimal has a relatively large memory footprint, however performing math operations gives you a more precise result.
        >- So, you should use decimal when working with financial data or any scenario where you need an accurate result from a calculation.

~ Deciphering large floating-point values ~
    $- Because floating-point types can hold large numbers with a lot of precision, their values can be represented using "E notation", which is a form of scientific notation that means "times ten raised to the power of." So, a value like 5E+2 would be the value 500 because it's the equivalent of 5 * 10^2, or 5 * 10 * 10.

                                        & Recap &
    >- A floating-point type is a simple value data type that can hold fractional numbers.
    >- Choosing the right floating-point type for your application requires you to consider more than just the maximum and minimum values that it can hold.
        @- You must also consider how many values can be preserved after the decimal, how the numbers are stored, and how their internal storage affects the outcome of math operations.
    >- Floating-point values can sometimes be represented using "E notation" when the numbers or exponents grow especially large.
    >- There's a fundamental difference in how the compiler and runtime handle decimal as opposed to float or double;
        @- especially when determining how much accuracy is necessary from math operations.
*/
using System;

namespace FloatingPointTypes
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("");
            Console.WriteLine("Floating point types - Minimum to Maximum Values:");
            Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
        }
    }
}
