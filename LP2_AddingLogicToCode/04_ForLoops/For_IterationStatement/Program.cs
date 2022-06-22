/*
& For Iteration-Statement &
& 9/9/21 &


? What is the `for` statement? ?
^   - the `for` statement iterates through a code block a specific number of times.
^   - This makes the `for` statement unique among the other iteration statements.
^   - gives you much more control over the process of iteration by exposing the conditions for iteration.
>          - REMINDER: The `foreach` statement iterates through a block of code once for each item in a sequence of data like an array or collection.
>          - REMINDER: The `while` statement iterates through a block of code until a condition is met.

@           ~ THERE ARE SIX PARTS TO A `FOR` STATEMENT: ~

* 1. The for keyword

* 2. A set of parenthesis that defines the conditions of for iteration.
?           - It contains three distinct parts, separated by the end of statement operator, a semi-colon.

* 3. The first part defines and initializes the iterator variable.
?           - In this example: int i = 0. The docs refer to this section as the initializer.

* 4. The second part defines the completion condition.
?           - In this example: i < 10. In other words, the runtime will continue to iterate over the code in the code block below the for statement while i is less than 10.
?           - Once i is greater or equal to 10, the runtime will continue executing code after the for statement's code block.
?           - The docs refer to this section as the CONDITION.

* 5. The third part defines the action to take after each iteration.
?           - In this case, after each iteration, i++ will increment the value of i by 1.
?           - The docs refer to this section as the ITERATOR.

* 6. Finally, the code block. This is the code that will be executed for each iteration.
?           - Notice that the value of i is referenced inside of the code block.
?           - The docs refer to this section as the BODY.


~                   -RECAP-                     ~
& The for iteration statement allows you to iterate through a block of code a specific number of times.
& The for iteration statement allows you to control every aspect of the iteration's mechanics by altering the three conditions inside the parenthesis:
?   - the initializer, condition, and iterator.
& It's common to use the for statement when you need to control how you want to iterate through each item in an array.
& If your code block has only one line of code, you can eliminate the opening and closing curly braces and white-space if you wish.

*/
using System;
using System.Threading;

namespace For_IterationStatement
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\nWelcome to the For-Iteration-Statement Lesson!\n\nPlease choose which lesson example to run:\nEnter [1] to run Countup example\nEnter [2] to run Countdown example\nEnter [3] to run Countup-Skip-3 example\nEnter [4] to run BreakKeyword example\nEnter [5] to run StringArrayIteration example\nEnter [6] to run Overcoming_ForEach_Limitations example\n");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    Console.WriteLine($"You entered {userChoice}.\nRunning 'Countup()' example:\n");
                    Thread.Sleep(1000);
                    Countup();
                    break;
                case "2":
                    Console.WriteLine($"You entered {userChoice}.\nRunning 'Countdown()' example:\n");
                    Thread.Sleep(1000);
                    Countdown();
                    break;
                case "3":
                    Console.WriteLine($"You entered {userChoice}.\nRunning 'Countup-Skip3()' example:\n");
                    Thread.Sleep(1000);
                    Skip3();
                    break;
                case "4":
                    Console.WriteLine($"You entered {userChoice}.\nRunning 'BreakKeyword()' example:\n");
                    Thread.Sleep(1000);
                    BreakKeyword();
                    break;
                case "5":
                    Console.WriteLine($"You entered {userChoice}.\nRunning 'IterateThroughArray()' example:\n");
                    Thread.Sleep(1000);
                    IterateThroughArray();
                    break;
                case "6":
                    Console.WriteLine($"You entered {userChoice}.\nRunning 'Overcoming_ForEach_Limitations()' example:\n");
                    Thread.Sleep(1000);
                    Overcoming_ForEach_Limitations();
                    break;
                default:
                    Console.WriteLine($"Invalid entry {userChoice}.\nMust enter a valid numeric input matching any of these: [1, 2, 3, 4, 5, 6]\n");
                    break;
            }
        }

        static void Countup() //? Switch-case "1"
        {
            // * Basic `for` statement.
            for (int i = 0; i < 10; i++) //LOOK: Exact same syntax as C++
            /*
            ! All three sections (initializer, condition, and iterator) are optional.
            ! However, in practice, typically all three sections are used.
            */
            {
                Console.WriteLine(i + 1); //? Counting up from 1 to 10
            }
            Console.WriteLine("\nIteration Complete.\n");
        }

        static void Countdown() //? Switch-case "2"
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i); //? Counting down from 10 to 1
            }
            Console.WriteLine("\nIteration Complete.\n");
        }

        static void Skip3() //? Switch-case "3"
        // * Iterate through value skipping 3 per iteration:
        {
            for (int i = 0; i < 10; i += 3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nIteration Complete.\n");
            //? Instead of incrementing or decrementing the value of the iterator variable by 1, we use i += 3 to skip two values after each iteration.
        }

        static void BreakKeyword() //? Switch-case "4"
        // Use the `break` keyword to exit the iteration statement premuturely based upon a certain condition.
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 7) break; //! Using a shortened statement!
            }
            Console.WriteLine("\nIteration complete.\n");
        }

        static void IterateThroughArray() //? Switch-case "5"
        /*
        ~ Iterating through array backwards:
        ~       - unable to do with the foreach statement.
        */
        {
            string[] names = { "Schlopp", "Beef", "Appleslice Jones", "Cauliflower Marvin", "Pork-Stain" };
            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("\nIteration Complete.\n");
        }


        /*static void LimitationsOf_foreach()
        //! This function using a ForEach statement to iterate through an array of strings will raise an exception:
        {
            string[] names = { "Schlopp", "Beef", "Appleslice Jones", "Cauliflower Marvin", "Pork-Stain" };
            foreach (var name in names)
            {
                try
                {

                    //! Can't do this:
                    if (name == "Cauliflower Marvin") name = "Sammy";
                    //! you can't reassign the value of name because it is part of the foreach iteration's inner implementation.
                }
                catch
                {
                    Console.WriteLine("Unable to reassign values because it is a 'Foreach iteration variable'.");
                }
            }
        }
        */

        static void Overcoming_ForEach_Limitations() //? Switch-case "6"
        //* In this example, you can overcome the foreach limitations by adding a For statement.
        //^    - Since the array isn't directly part of the iteration statement's implementation, you can change values inside of the array.
        {
            string[] names = { "Schlopp", "Beef", "Appleslice Jones", "Cauliflower Marvin", "Pork-Stain" };
            for (int i = 0; i < names.Length; i++)
                if (names[i] == "Cauliflower Marvin") names[i] = "Sammy"; //? Changes index value to "Sammy" if "Cauliflower Marvin" found.

            foreach (var name in names) Console.WriteLine(name);
            Console.WriteLine("\nIteration Complete.\n");
        }
    }
}
