/*
                            & Integral Types &
                                * 10/17/21 *
    >- An integral type is a simple value type that represents whole numbers (non-fractional).
    >- The most popular in this category is the "int" data type.

    $- There are two subcategories of integral types: signed and unsigned integral types.

                        % SIGNED Integral Types %
    <- A signed type uses its bytes to represent an equal number of positive and negative numbers.

                        ~ UNSIGNED Integral Types ~
    >- An unsigned type uses its bytes to represent only positive numbers.

                                * Recap *
    @ An integral type is a simple value data type that can hold whole numbers.
    @ There are signed and unsigned data types. Signed integral types use one bit to store whether the value is positive or negative.
    @ You can use the MaxValue and MinValue properties of numeric data types to evaluate whether a number can fit in a given data type.
*/

using System;

namespace IntegralTypes
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter the number of which Integral Type you wish to see an example of:\n\n1.) Signed Integral Types\n2.) Unsigned Integral Types");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                SignedInts();
            }
            else if (choice == "2")
            {
                UnsignedInts();
            }
        }

        static void SignedInts()
        {
            Console.WriteLine("\nSigned integral types - Minimum to Maximum Possible Values:\n=============================================================\n");

            Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
        }

        private static void UnsignedInts()
        {
            Console.WriteLine("\nUnsigned integral types - Minimum to Maximum Possible Values:\n=============================================================\n");

            Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
        }
    }
}
