/*
~           What is the do-while statement?         ~
^ The "do" statement executes a statement or a block of statements while a specified Boolean expression evaluates to true.
^ Because that expression is evaluated after each execution of the loop, a "do-while" loop executes ONE OR MORE TIMES.
*           do
*           {
*               // This code executes at least one time
*           } while (true)

&           RECAP           &
@ The do-while statement iterates through a code block at least once, and may continue to iterate based on a Boolean expression. The evaluation of the Boolean expression usually depends on some value generated or retrieved inside of the code block.
@ The while statement evaluates a Boolean expression first, and continues to iterate through the code block as long as the Boolean expression evaluates to true.
@ The continue keyword to step immediately to the Boolean expression.
*/

using System;

namespace Do_DoWhile_Continue
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter which example to run:\n[1]. BreakOnNumber()\n[2]. BreakOnLessThan()\n[3]. UsingContinue()\n> ");
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("");
                    BreakOnNumber();
                    break;
                case "2":
                    Console.WriteLine("");
                    BreakOnLessThan();
                    break;
                case "3":
                    Console.WriteLine("");
                    UsingContinue();
                    break;
                default:
                    Console.WriteLine("\t-ERROR-\nUser must enter a choice between [1-3].\n");
                    break;
            }

            //@ Code will keep generating random numbers between 1 and 10 until we generate the number 7
            static void BreakOnNumber()
            {
                Random random = new();      //! Create random number generator
                int current;                //! Declare variable to contain the random numbers outside of loop-scope.

                //? Loop will print numbers until 7 is generated, thus ending loop.
                do
                {
                    current = random.Next(1, 11);
                    Console.WriteLine($"> {current}");
                } while (current != 7);
                Console.WriteLine($"\nDone! Last Number: {current}");
            }

            //@ Code will only iterate loop if starting-number is >= 3, and will break upon generating anything < 3.
            static void BreakOnLessThan()
            {
                Random random = new();              //! Create random number generator
                int current = random.Next(1, 11);   //! Declare starting-number outside of loop-scope.

                while (current >= 3) //? Acts as a "gate" that only iterates loop if "current" is >= 3.
                {                    //? Prevents starting number from being <3.
                    Console.WriteLine($"> {current}");
                    current = random.Next(1, 11);
                }
                Console.WriteLine($"\nDone! Last Number: {current}");
            }

            //@ Utilizes "continue" skips iteration so that nothing greater than 7 is printed.
            static void UsingContinue()
            {
                Random random = new();           //! Create random number generator
                int current;                     //! Declare variable to hold all values.
                do
                {
                    current = random.Next(1, 11);

                    if (current >= 8) continue;  //! Immediately restart iteration.

                    Console.WriteLine($"> {current}");
                } while (current != 7);
                Console.WriteLine($"\nDone! Last Number: {current}");
            }
        }
    }
}
