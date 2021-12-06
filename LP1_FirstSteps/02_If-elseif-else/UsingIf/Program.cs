/*
! Take First Steps in C#
^ Adding Decision-Logic Using If-ElseIf-Else
? Using If - Creating a Random Dice Game Pt 1

* We'll use the Random.Next() method to simulate rolling three 6-sided dice.
* We'll evaluate the values to calculate the score.
* If the score is greater than an arbitrary total, then we'll display a winning
* message to the user. Otherwise, we'll display a losing message to the user.
                        ! RULES !
? 1. If any two dice you roll result in the same value, you get TWO bonus points for rolling doubles.
? 2. If all three dice you roll result in the same value, you get SIX bonus points for rolling triples.
? 3. If the sum of the three dice rolls, plus any point bonuses, is 15 OR GREATER, you WIN the game. Otherwise, you lose.
*/
using System;

namespace UsingIf
{
    class Program
    {
        static void Main()
        {
            Random dice = new(); // Creates a new class instance when called.

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            //^ Rule 1.
            if (roll1 == roll2 || roll1 == roll3 || roll2 == roll3)
            {
                total += 2;
                Console.WriteLine("\nNice, you got doubles! +2 Bonus Points!");
            }

            //^ Rule 2.
            if ((roll1 == roll2) && (roll1 == roll3))
            {
                total += 6;
                Console.WriteLine("\nWOW, TRIPLES!!! +6 Bonus Points!");
            }

            //^ Rule 3.
            if (total < 15)
            {
                Console.WriteLine("\nSorry, You Lose!");
            }
            if (total >= 15)
            {
                Console.WriteLine("\nYou Win!");
            }
        }
    }
}
