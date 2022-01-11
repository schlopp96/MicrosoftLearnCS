/*
! Take First Steps in C#
^ Adding Decision-Logic Using If-ElseIf-Else
? Using ElseIf-Else - Creating a Random Dice Game Pt 2

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
            int DiceTotal = roll1 + roll2 + roll3;
            Console.WriteLine($"\n______________\n| Dice roll: |\n| Die 1 -> {roll1} |\n| Die 2 -> {roll2} |\n| Die 3 -> {roll3} |\n--------------\nTotal: {DiceTotal} points.");

            //* Using nesting, the user will no longer receive both a double AND triple bonus.
            if (roll1 == roll2 || roll1 == roll3 || roll2 == roll3)
            {
                //^ Rule 2.
                if ((roll1 == roll2) && (roll1 == roll3))
                {
                    DiceTotal += 6;
                    Console.WriteLine("\nWOW, TRIPLES!!! +6 Bonus Points!");
                }
                //^ Rule 1
                else
                {
                    DiceTotal += 2;
                    Console.WriteLine("\nNice, you got doubles! +2 Bonus Points!");
                }
            }
            //^ Rule 3.
            if (DiceTotal >= 16)
            {
                Console.WriteLine("\nCongratulations!! You win a BRAND NEW SMART CAR!! Good luck not drowning in pussy!");
                Console.WriteLine("\nPress anything to exit.");
                Console.ReadKey(true);
            }
            else if (DiceTotal > 10 && DiceTotal < 16)
            {
                Console.WriteLine("\nOkay nice job!! You win a new Terry Crews replicated DILDO!!!\nGood luck getting that outta there...!");
                Console.WriteLine("\nPress anything to exit.");
                Console.ReadKey(true);

            }
            else if (DiceTotal == 7)
            {
                Console.WriteLine("\nHey, alright nice! Lucky number seven! You win this gently-used roll of TOILET PAPER!");
                Console.WriteLine("\nPress anything to exit.");
                Console.ReadKey(true);

            }
            else
            {
                Console.WriteLine("\nSuprise!!!!\nWay to go dumbfuck, you lost.\nHere, take this trash out too while you're leaving, loser.");
                Console.WriteLine("\nPress anything to take out the trash and exit.");
                Console.ReadKey(true);
            }
        }
    }
}
