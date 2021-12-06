/*
! Boolean Expressions !
    & 8/22/21 &

! What is an Expression? !
*   - An expression is any combination of values (literal or variable), operators, and methods that return a single value.
*       - A statement is a complete instruction in C#, and statements are comprised of one or more expressions.

! "Massaging" data !
* - "Massaging" the data means that you need to perform some cleanup before you perform a comparison for equality.
*   - Can use several built-in helper methods to cleanup comparisons.
*       - `Trim()` removes leading and trailing whitespace.
*   - `ToUpper()` & `ToLower()` also useful to ensure values have matching case.

! What is logical negation? !
* - "Logical Negation" refers to the [!] operator.
* - Adding the [!] operator before a conditional expression checks to ensure the expression is false.
    & Both lines do the same thing below:
        ^ string pangram = " The quick brown fox jumps over the lazy dog.
        ^ Console.WriteLine(pangram.Contains("fox") == false);
        ^ Console.WriteLine(!pangram.Contains("fox"));

! RECAP:
~-There are many different kinds of expressions that evaluate to either true or false.
~- Evaluate equality using the == operator.
~- Evaluating equality of strings requires you consider the possibility that the strings have different case and leading or trailing spaces.
~    - Depending on your situation, use the ToLower() or ToUpper() helper methods, and the Trim() helper method to improve the likelihood that two strings are equal.
~- Evaluate inequality using the != operator.
~- Evaluate greater than, less than and similar operations using comparison operators like >, <, >=, and <=.
~- If a method returns a bool, it can be used as a Boolean expression.
~- Use the logical negation operator [!] to evaluate the opposite of a given expression.
*/


using System;

namespace BooleanExpressions
{
    class Program
    {
        static void Main()
        {
            EqualityOperator();
            InequalityOperator();
            ComparisonOperators();
            LogicalNegation();

            static void EqualityOperator()
            {
                //& EQUALITY Operator: "=="
                Console.WriteLine("\nEQUALITY Operation Ex:\n");

                Console.WriteLine("a" == "a");
                Console.WriteLine("a" == "A"); //! When comparing strings, case matters.
                Console.WriteLine(1 == 2);

                string myValue = "a";
                Console.WriteLine(myValue == "a");

                string valA = "a";
                string valB = " a";
                //!  if you need to accept a match that is inexact, you can "massage" the data first.
                Console.WriteLine(valA.Trim().ToLower() == valB.Trim().ToLower());
            }

            static void InequalityOperator()
            {
                //& INEQUALITY Operator: "!="
                Console.WriteLine("\nINEQUALITY Operation Ex:\n'a' != 'a'?\n'a' != 'A'?\n 1 != 2? \n'a' != 'a'?\n");
                string myValue = "a";
                Console.WriteLine("a" != "a");
                Console.WriteLine("a" != "A");
                Console.WriteLine(1 != 2);

                Console.WriteLine(myValue != "a");
            }

            static void ComparisonOperators(){
                Console.WriteLine("\nUsing Comparison Operators:\n1 > 2?\n1 < 2?\n1 >= 1?\n1 <= 1?\n");
                Console.WriteLine(1 > 2);
                Console.WriteLine(1 < 2);
                Console.WriteLine(1 >= 1);
                Console.WriteLine(1 <= 1);
            }

            static void LogicalNegation(){
                string pangram = "The quick brown fox jumps over the lazy dog.";
                Console.WriteLine($"\n\"{pangram}\"\nStatement contains 'fox'?\nStatement contains 'cow'?\n");
                //? Returns boolean values:
                Console.WriteLine(pangram.Contains("fox"));
                Console.WriteLine(pangram.Contains("cow"));

                Console.WriteLine("WITH LOGICAL NEGATION:");
                //! Using Logical Negation Operator:
                Console.WriteLine(!pangram.Contains("fox"));
                Console.WriteLine(!pangram.Contains("cow"));

            }
        }
    }
}
