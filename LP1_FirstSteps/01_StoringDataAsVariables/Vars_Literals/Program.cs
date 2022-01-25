/*
~ Taking First Steps in C#
~ Storing Data:
& Variables & Literals
*/
using System;

namespace Vars_Literals
{
    class Program
    {
        static void Main()
        {
            Literals();
            Variables();

        }
        static void Literals()
        {
            Console.WriteLine("Hello!"); //& NOTE: A literal value is a hard - coded value that never changes.
            Console.WriteLine(124); //? Prints what you write "Literally"... Thus called a "literal".
            Console.WriteLine(true); //? Essentially a value not stored as a variable.
            Console.WriteLine(false);
            Console.WriteLine(15.5m); //? Decimals require a caseless "m" character to present correctly.
            Console.WriteLine('A');
        }

        static void Variables()
        {
            //! Declaring a Variable:
            string name;
            //! Getting/Assigning a value to a variable:
            name = "Schlopp";
            Console.WriteLine(name);
            // Implicitly-typed variables:
            var message = "Hello there!"; //< LOOK: The [var] keyword tells compiler to infer variable type based on the value initialized to.
            Console.WriteLine(message); //$ `message` is typed as a string by the compiler, and can no longer be changed.
        }
    }
}
