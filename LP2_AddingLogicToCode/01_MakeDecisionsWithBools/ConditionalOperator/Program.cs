/**
 * <summary>
 * ! Conditional Operator !
 * & 8/24/21 &
 * ? The conditional operator ?
 * * - commonly known as the ternary conditional operator.
 * * - evaluates a Boolean expression, and returns the result of evaluating one of two expressions, depending on whether the Boolean expression evaluates to true or false.
 *
 * *    Here's the basic form:
 * * "<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>"
 *
 * ! Recap !
 * * You should remember the following about the conditional operator:
 * * Use the conditional operator when you need to add branching logic inline.
 * * Use the conditional operator when you need to return a value based on a binary condition ... return this when true, return that when false.
 * </summary>
 */

using System;

namespace ConditionalOperator
{
    class Program
    {
        static void Main()
        {
            //* Generate random sale on program run.
            Random saleAmount = new();

            //~ Applies 50% discount if `saleAmount` > 1000
            int discount = saleAmount.Next(2000) > 1000 ? 100 : 50; //> if salesAmount.Next(2000) is > 1000 then discount = 100, else 50.

            if (discount == 100)
            {
                Console.WriteLine("\n50% Discount Applied: No.");
            }
            else
            {
                Console.WriteLine("\n50% Discount Applied: Yes.");
            }
        }
    }
}