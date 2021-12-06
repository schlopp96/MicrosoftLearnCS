/*
&           RPG Battle Challenge            $
        @           9/13/21         @


&               Game Rules:                 &
~ - The hero and the monster will start with 10 health points.
~ - All attacks will be a value between 1 and 10.
~ - The hero will attack first.
~ - Print the amount of health the monster lost and their remaining health.
~ - If the monster's health is greater than 0, it can attack the hero.
~ - Print the amount of health the hero lost and their remaining health.
~ - Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
~ - Print the winner.
!     - Must use either DO-WHILE or WHILE statement.
!     - No matter how you do it, your code should produce a similar output:
*         - Monster was damaged and lost 1 health and now has 9 health.
*         - Hero was damaged and lost 1 health and now has 9 health.
*         - Monster was damaged and lost 7 health and now has 2 health.
*         - Hero was damaged and lost 6 health and now has 3 health.
*         - Monster was damaged and lost 9 health and now has -7 health.
*         - Hero wins!
*/


using System;

namespace Challenge_RPGBattle
{
    class Program
    {
        static void Main()
        {
            int hero = 10;                      //* Starting Hero Health
            int monster = 10;                   //! Starting Monster Health

            Random damage = new();              //~ RNG to calculate attack damage.

            do                                  //@ Hero will always attack first (using a do-while loop).
            {
                int Attack = damage.Next(1, 11);
                monster -= Attack;
                Console.WriteLine($"Monster was damaged and lost {Attack} health and now has {monster} health");

                if (monster <= 0) break;        //? If monster is killed then exit loop

                Attack = damage.Next(1, 11);    //> Necessary to call method again for new random number gen.
                hero -= Attack;
                Console.WriteLine($"Hero was damaged and lost {Attack} health and now has {hero} health");

            } while (hero > 0 && monster > 0);  //$ While both alive, continue fight until condition is met.

            Console.WriteLine(hero > monster ? $"\nHero wins with {hero} health remaining!" : $"\nMonster wins with {monster} health remaining!");
        }
    }
}
