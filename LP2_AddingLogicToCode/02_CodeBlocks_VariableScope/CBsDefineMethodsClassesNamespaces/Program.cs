/*
! CODEBLOCKS define METHODS, CLASSES, & NAMESPACES !
~   - Code Blocks are CRITICAL to defining higher-level structures for our code. ~

^ Calling a Method in the Same Class: ^
        * using System;
        *
        * namespace MyNewApp
        * {
        *     class Program
        *     {
        *         static void Main()
        *         {
        *             string value = "Microsoft Learn";
        *             string reversedValue = Reverse(value);
        *             Console.WriteLine($"Secret message: {reversedValue}");
        *         }
        * // ^ Since the Reverse() method is defined in the same class, the code that calls the method doesn't need to qualify the method's name with the class name.
        *         static string Reverse(string message)
        *         {
        *             char[] letters = message.ToCharArray();
        *             Array.Reverse(letters);
        *             return new string(letters);
        *         }
        *     }
        * }


^ Calling a Method from a DIFFERENT CLASS: ^
        * using System;
        *
        * namespace MyNewApp
        * {
        *     class Program
        *     {
        *         static void Main()
        *         {
        *             string value = "Microsoft Learn";
        *             string reversedValue = Utility.Reverse(value);
        *             Console.WriteLine($"Secret message: {reversedValue}");
        *         }
        *     }
        *
        *     class Utility
        *     {
        *         public static string Reverse(string message)
        *         {
        *             char[] letters = message.ToCharArray();
        *             Array.Reverse(letters);
        *             return new string(letters);
        *         }
        *     }
        * }

^ Referencing a Class from a DIFFERENT NAMESPACE: ^

        * using System;
        *
        * namespace MyNewApp
        * {
        *     class Program
        *     {
        *         static void Main()
        *         {
        *             string value = "Microsoft Learn";
        *             string reversedValue = MyNewApp.Utilities.Utility.Reverse(value);
        *             Console.WriteLine($"Secret message: {reversedValue}");
        *         }
        *     }
        * }
        *
        * namespace MyNewApp.Utilities
        * {
        *     class Utility
        *     {
        *         public static string Reverse(string message)
        *         {
        *             char[] letters = message.ToCharArray();
        *             Array.Reverse(letters);
        *             return new string(letters);
        *         }
        *     }
        * }

^ The Using Statement: ^
? - Resolves the class names that are used in the file, instructing the compiler to look at the list of namespaces to find all of the class names.

        * using System;
        * using MyNewApp.Utilities;
        *
        * namespace MyNewApp
        * {
        *     class Program
        *     {
        *         static void Main()
        *         {
        *             string value = "Microsoft Learn";
        *             string reversedValue = Utility.Reverse(value);
        *             Console.WriteLine($"Secret message: {reversedValue}");
        *         }
        *     }
        * }
        *
        * namespace MyNewApp.Utilities
        * {
        *     class Utility
        *     {
        *         public static string Reverse(string message)
        *         {
        *             char[] letters = message.ToCharArray();
        *             Array.Reverse(letters);
        *             return new string(letters);
        *         }
        *     }
        * }

& RECAP: &
~ - Code blocks define higher-level structures like namespaces, classes, and methods.
~ - Just as code blocks affect the visibility of variables defined inside of lower-level structures like decision and iteration statements, code blocks also affect the visibility of methods between classes, and classes between namespaces.
~ - The using statement can be added to code files to instruct the compiler where to look for references to classes.
*/


using System;

namespace CBsDefineMethodsClassesNamespaces
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
