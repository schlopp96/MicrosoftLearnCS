/*
!Code blocks and variable scope!
& 8/29/21 &

^ Code Block - one or more statements that define an execution path.
?       - Typically affected by statements OUTSIDE the code block.
?       - Also affects variable scope.

^ Variable Scope - visibility of the variable to the other code in application.
?       - Locally scoped vars only accessible inside the code block in which it was defined.
*/
using System;

namespace VariableScope
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter [1] to crash the program.\nEnter [2] to see the fixed version of the program.\n");
                string user_choice = Console.ReadLine();
                if (user_choice.ToLower().Contains("1"))
                {
                    localVariableScopeERROR();
                    break;
                }
                else if (user_choice.ToLower().Contains("2"))
                {
                    localVariableScopeSUCCESS();
                    break;
                }
                else
                {
                    Console.WriteLine($"\nERROR:\nINVALID ENTRY: {user_choice}\n");
                }
            }

            void localVariableScopeERROR()
            {
                bool flag = true;
                if (flag)
                    // int value; //! Moving Var outside doesn't work without assignment.
                {
                    int value = 10; //* <- Local variable initialized.
                    Console.WriteLine($"\nInside of code block: {value}");
                }
                Console.WriteLine("Outside of code block: {value}\n\nERROR:\nThe name 'value' does not exist in the current context\n");
                //! ^ Can't be accessed outside code block (invalid scope).

                Console.WriteLine("\nOPERATION FAILURE");
            }

            void localVariableScopeSUCCESS()
            {
                bool flag = true;
                int value; //* initialized variable in outside scope...
                if (flag)
                {
                    value = 10; //* <- Assigning value to local variable within inner scope.
                    Console.WriteLine($"\nInside of code block: {value}");
                    //* ^ WORKS
                }
                value = 10; //* <- Assigning value to variable in OUTSIDE SCOPE.
                Console.WriteLine($"Outside of code block: {value}");
                //* ^ DOES WORK, AS LONG AS VARIABLE IS ASSIGNED CORRECT VALUE-TYPE WITHIN APPROPRIATE SCOPE.

                Console.WriteLine("\nOPERATION SUCCESS");

            }
        }
    }
}
