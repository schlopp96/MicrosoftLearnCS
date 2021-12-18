/*
                                        >   The TryParse() Method   <
                                            &   10/28/2021   &
*- When working with data, you'll likely need to convert string data into a numeric data type.
*- As you learned in the previous unit, because the string data type can hold a non-numeric value, it's possible that performing a conversion from a string into a numeric data type will cause a runtime error.

^- To avoid a format exception, use the TryParse() method on the target data type.

                        ~- The TryParse() method does several things simultaneously:

    @- It attempts to parse a string into the given numeric data type.
    @- If successful, it will store the converted value in an out parameter.
    @- It returns a bool to indicate whether the action succeeded or failed.
        $- We can use the bool to take action on the value (like perform a calculation) or display a message if unsuccessful.
    NOTE: //& Although we are using the `int` data type, there are similar `TryParse` methods available for all numeric data types.

                                >   What is an `out` Parameter?   <
$- Methods can return a value or return "void", meaning they return no value.
$- Methods can also return values through out parameters, which are defined just like an input parameter, but include the out keyword.
$- When calling a method with an `out` param, you must also use the keyword "out" before the variable, which will hold the value.
    ^- You can then use the value contained in the out param throughout the rest of your code.
*/

using System;

namespace TryParse
{
    class Program
    {
        static void Main()
        {
            UsingTryParse();
        }

        static void UsingTryParse()
        {
            Console.Write("\nPlease Enter Measurement Value: ");
            string value = Console.ReadLine();

            if (int.TryParse(value, out int result)) //< Takes in the string: `value` and outputs new int: `result`.
            {
                Console.WriteLine($"\nMeasurement: {result}."); //^ Returns true if successfully converted string into int; else false.
            }
            else
            {
                Console.WriteLine($"\nUnable to convert measurement: \"{value}\".\nIncompatible with conversion to `integer` type.");
            }

            //@ Since `out` var is defined outside the scope of the if statement, it can be accessed later in your code:

            if (result >= 0)
            {
                Console.WriteLine($"Measurement (w/ offset): {50 + result}");
            }
            else Console.WriteLine("\nAlso, I murdered my wife and committed several war crimes while in Bosnia lol.");

            Console.WriteLine("\nPress anything to continue.\n");
            Console.ReadKey(true);

        }
    }
}
