/*
~ Array Basics ~
& 8/14/21 &

?     What Is An Array?
* An array is a sequence of individual data elements accessible through a single variable name.
* Special type of variable that can hold multiple values of the same data type.
* Uses zero-based indexing (starts at 0).
*/
using System;

namespace ArrayBasics
{
    class Program
    {
        static void Main()
        {

            /*
            ~ Declaring an Array: ~
            ? - The syntax to declare an array is strange because we must specify both data type and size of array:
            ^ - first brackets declare variable's array type.
            ^ - second contains the number of elements that the array will hold.
            string[] fraudulentOrderIDs = new string[3];*/

            /*
            //~ Assigning values to Elements of an Array: ~//
            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789";
            //fraudulentOrderIDs[3] = "D000"; //! - You cannot access/assign values beyond the array's size
            */
            // * Arrays can also be initialized upon declaration just like variables:
            string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

            //~ Get Vals from Array Elements ~//
            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

            //& - The elements of an array are just like any other variable,
            //&  as element values can be assigned, retrieved, and reassigned.
            fraudulentOrderIDs[0] = "F000";
            Console.WriteLine($"\nReassign First: {fraudulentOrderIDs[0]}\n");

            Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
        }
    }
}
