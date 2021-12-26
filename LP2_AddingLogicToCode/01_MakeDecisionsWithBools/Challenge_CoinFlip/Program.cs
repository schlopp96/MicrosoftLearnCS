/*
^ Coin-Flip Code Challenge
& 8/24/21

~ Write code in the .NET Editor to display the result of a coin flip
~ Use the Random class to generate a value. Based on the value, use the conditional operator to display either heads or tails.
~ There should be a 50% chance that the result is either heads or tails.
! You should be able to accomplish the desired result in three lines of code or less.
~ Whether you get stuck and need to peek at the solution or you finish successfully, continue on to view a solution to this challenge.
? Conditional Operator [?] Syntax:
? <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
*/

using System;

namespace Challenge_CoinFlip
{
    class Program
    {
        static void Main()
        {
            while (true)
            {

                Console.WriteLine("\nPlease Choose an Example to View:\n\n[1]. Classic If-Else\n[2]. Conditional Operator\n[ANYTHING ELSE]. Exit");
                Random Flip = new();
                int Coin = Flip.Next(0, 2);
                string userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    ex1();
                    continue;
                }
                else if (userChoice == "2")
                {
                    ex2();
                    continue;
                }
                else
                {
                    break;
                }

                void ex1()
                {
                    Console.WriteLine("\n\nExample 1:\nif (Flip.Next(0, 2) == 0)\n{\n\tConsole.WriteLine('\\nYou rolled a 0: Heads!');\n}\nelse\n{\n\tConsole.WriteLine(\'\\nYou rolled a 1: Tails!');\n}");

                    if (Flip.Next(0, 2) == 0)
                    {
                        Console.WriteLine("\nYou rolled a 0: Heads!");
                    }
                    else
                    {
                        Console.WriteLine("\nYou rolled a 1: Tails!");
                    }
                }
                void ex2()
                {
                    Console.WriteLine("\n\nExample 2:\nConsole.Write($\"\\nYou rolled a {coin}: \");\nConsole.WriteLine((Coin == 0) ? \"Heads!\" : \"Tails!\");");
                    Console.Write($"\nYou rolled a {Coin}: ");
                    Console.WriteLine((Coin == 0) ? "Heads!" : "Tails!");
                }
            }
        }
    }
}
