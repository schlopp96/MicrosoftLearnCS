/*
> Data Type Casting & Conversion <
        & 10.22.21 &

*-> There are multiple techniques to perform a data type conversion or cast.
*-> Which technique you choose depends on your answer to two important questions:

!================================================================================

* - Question 1: Is it possible, depending on the value, that attempting to change the value's data type would throw an exception at run time?
            > int first = 2;
            > string second = "4";
            > int result = first + second;
            > Console.WriteLine(result);
        @- Here, we're attempting to add the values 2 and 4. The value 4 is of type string. Will this work?
            > Output:
            > (3,14): error CS0029: Cannot implicitly convert type 'string' to 'int'

        @- The error message tells us the problem is with our use of the string data type.
        @- But why can't the C# Compiler just handle this? After all, we can do the opposite to concatenate a number to a string and save it in a string variable.

        @- Here', we'll merely change the data type of the result variable from int to string.
            > int first = 2;
            > string second = "4";
            > string result = first + second;
            > Console.WriteLine(result);
            > And this will produce the following output:

            > Output
            > 24

        @- Let's return to our first code example where the result variable is of type int.
            ~- Why can't the C# compiler figure out that we want to treat the variable second containing 4 as a number, not a string?
            ~- The C# compiler sees a potential problem in the making.
                ^- The variable `second` is of type string, so it might be set to a different value like "hello".
                ^-If the C# compiler attempted to convert "hello" to a number that would cause an exception at runtime.
                ^- To avoid this possibility, the C# compiler will not implicitly perform the conversion from string to int for you.

        @- From the C# compiler's perspective, the safer operation would be to convert int into a string and perform concatenation instead.
            $- If you intend to perform addition using a string, the C# compiler requires you to take more explicit control of the process of data conversion.
                ?- In other words, it forces you to be more involved so that you can put the proper precautions in place to handle the possibility that the conversion could throw an exception.
            $@- If you need to change a value from the original data type to a new data type and the change could produce an exception at run time, you must perform a data conversion.

        @- To perform data conversion, you can use one of several techniques:
            > Use a helper method on the data type
            > Use a helper method on the variable
            > Use the Convert class' methods
            > We'll look at a few examples of these techniques for data conversion later in this unit.

!====================================================================================================

*- Question 2: Is it possible, depending on the value, that attempting to change the value's data type would result in a loss of information?

        @- Step 2 - Modify the code in the .NET Editor to perform an implicit conversion
        @- Delete or comment out the code from the previous exercise step and add the following code in the .NET Editor:

            > int myInt = 3;
            > Console.WriteLine($"int: {myInt}");

            >decimal myDecimal = myInt;
            >Console.WriteLine($"decimal: {myDecimal}");
        ?- When you run the code, you should see the following output:
            > int: 3
            > decimal: 3

        @- The key is this line of code:
            > decimal myDecimal = myInt;

            ? Since any int value can easily fit inside of a decimal, the compiler performs the conversion.


        @- The term NARROWING CONVERSION conversion means that you're attempting to convert a value from a data type that can hold more information to a data type that can hold less information.
            > In this case, you may lose information such as precision (that is, the number of values after the decimal point).
            > An example of this would be converting value stored in a variable of type decimal and now convert that value into a variable of type int. If you were to print out the two values, you would possibly notice the loss of information.
            & When you know you'll be performing a narrowing conversion, you'll need to perform a cast.

        @- CASTING is an instruction to the C# compiler that you know precision may be lost, but you're willing to accept it.

!====================================================================================================

* Use ToString() to convert a number to a string

    @- Every data type variable has a ToString() method.
    @- What the ToString() method does depends on how it's implemented on a given type. However, on most primitives, it performs a widening conversion.
    @- While this isn't strictly necessary (since we can rely on implicit conversion in most cases) it can communicate to other developers that you understand what you're doing and it's intentional.

!====================================================================================================

* Data Conversion Using the Convert Class

    @- The Convert class has many helper methods to convert a value from one type into another.
    @- The ToInt32() method has 19 overloaded versions allowing it to accept virtually every data type as we'll see in a moment.
    @- We used the Convert.ToInt32() method with a string in the example, but you should probably use TryParse() when possible.
    @- So, when should we use the Convert class? The Convert class is best for converting fractional numbers into whole numbers (int) because it rounds up the way you would expect.

* Casting versus Conversion

    @- The following example demonstrates what happens when you attempt to cast a decimal into an int (a narrowing conversion) versus using the Convert.ToInt32() method to convert the same decimal into an int:
    @- When casting, the value of the float is truncated, meaning the value after the decimal is ignored completely. We could change the literal float to 1.999m and the result of casting would be the same.

    @- When converting using Convert.ToInt32(), the literal float value is properly rounded up to 2. If we changed the literal value to 1.499m, it would be rounded down to 1.

* ======================================Recap====================================== *
    * We covered several important concepts of data conversion and casting:

        @- Perform a data conversion when it's possible that doing so could cause a runtime error.
        @- Perform an explicit cast to tell the compiler you understand the risk of losing data.
        @- Rely on the compiler to perform an implicit cast when performing an expanding conversion.
        @- Use the () cast operator and the data type to perform a cast (for example, (int)myDecimal).
        @- Use the Convert class when you want to perform a narrowing conversion, but want to perform rounding, not a truncation of information.
*/

using System;
using System.Threading;

namespace DataTypeCasting
{
    class Program
    {
        static void Main()
        {
            WideningVSNarrowing.ImplicitConversion();
            Pause();
            WideningVSNarrowing.CastingConvertion();
            Pause();
            HelperMethods.HM_ToString();
            Pause();
            HelperMethods.HM_Parse();
            Pause();
            HelperMethods.ConvertClass();
            Pause();
            HelperMethods.CastingVSConverting();
            Pause();
        }

        private static void Pause()
        {
            Thread.Sleep(2000);
            Console.WriteLine("\nPress anything to continue...");
            Console.ReadKey(false);
        }
    }

    class WideningVSNarrowing
    {
        public static void ImplicitConversion()
        {
            //> Implicit Conversion is handled by the compiler
            Console.WriteLine("\n--- Implicit Conversion ---\nImplicit Conversion of Int to Decimal Through Variable Assignment:\nint myInt = 3;\ndecimal myDecimal = myInt;\n\nOutput:");
            int myInt = 3;
            Console.WriteLine($"\tint: {myInt}");
            decimal myDecimal = myInt; //^ Since any int value can easily fit inside of a decimal, the compiler performs the conversion.
            Console.WriteLine($"\tmyDecimal: {myDecimal}");
        }

        public static void CastingConvertion()
        {
            Console.WriteLine("\n\n--- CASTING CONVERSION ---\nNarrowing conversion of a decimal -> int using CASTING\n\nCASTING is an instruction to the compiler that you know you may lose some information and are ok with it.\n\nTo perform a casting conversion, use () around the data type you wish to convert the var to, and place it before the object:\n\n\tEx: (int)myDecimal\n");
            decimal myDecimal = 3.14m;
            Console.WriteLine($"\tdecimal: {myDecimal}");

            int myInt = (int)myDecimal;
            Console.WriteLine($"\tCasting decimal to int: {myInt}");
        }
    }

    class HelperMethods
    {
        public static void HM_ToString()
        {
            Console.Write("\n\n--- Helper Method: ToString() ---\n\n\tint first = 5;\n\tint second = 7;\n\tstring message = first.ToString() + second.ToString();\n\n\tOutput: ");
            int first = 5;
            int second = 7;
            string message = first.ToString() + second.ToString();
            Console.WriteLine(message);
        }

        public static void HM_Parse()
        {
            Console.Write("\n\n--- Helper Method: Parse() ---\n\n\tstring first = \"5\";\n\tstring second = \"7\";\n\tint sum = int.Parse(first) + int.Parse(second);\n\n\tOutput: ");
            string first = "5";
            string second = "7";
            int sum = int.Parse(first) + int.Parse(second);
            Console.WriteLine(sum);
        }

        public static void ConvertClass()
        {
            Console.Write("\n\n--- Helper Method: Class Convert() ---\n\n\tstring val1 = \"5\";\n\tstring val2 = \"7\";\n\tint result = Convert.ToInt32(val1) + Convert.ToInt32(val2);\n\n\tOutput: ");

            string value1 = "5";
            string value2 = "7";
            int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
            Console.WriteLine(result);
        }

        public static void CastingVSConverting()
        {
            Console.Write("\n\n--- Casting VS Converting ---\n\nWhen casting, the value of the float is truncated, meaning the value after the decimal is ignored completely.\nWe could change the literal float to 1.999m and the result of casting would be the same.\n\nWhen converting using Convert.ToInt32(), the literal float value is properly rounded up to 2.\nIf we changed the literal value to 1.499m, it would be rounded down to 1.\n\n\tint val = (int)1.5m\n\tint val2 = Convert.ToInt32(1.5m)\n\n");
            int value = (int)1.5m; // casting truncates

            Console.WriteLine($"\tCasting output: {value}\n");
            int value2 = Convert.ToInt32(1.5m); // converting rounds up
            Console.WriteLine($"\tConversion output: {value2}");
        }
    }
}
