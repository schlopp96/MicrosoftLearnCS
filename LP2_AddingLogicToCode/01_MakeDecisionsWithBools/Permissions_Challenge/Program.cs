/*
! Complicated Permissions Challenge
& 8/29/21 &
? In this challenge, you'll implement business rules that restrict access to users based on their permissions and their level.
? You'll display a different message to the user depending on their permissions and level.
~ 1.   - If the user is an Admin with a level greater than 55, output the message:
        ! "Welcome, Super Admin user."
~ 2.   - If the user is an Admin with a level less than or equal to 55, output the message:
        ! "Welcome, Admin user."
~ 3.   - If the user is a Manager with a level 20 or greater, output the message:
        ! "Contact an Admin for access."
~ 4.   - If the user is a Manager with a level less than 20, output the message:
        ! "You do not have sufficient privileges."
~ 5.   - If the user is not an Admin or a Manager, output the message:
        ! "You do not have sufficient privileges."
? When you run the code, including the sample data from Step 2, you should see the following output:
        ! "Welcome, Admin user."

                        ^   IMPORTANT   ^
*   - Use the string helper method `Contains()` to determine whether the permission variable's value contains one of the permission values.
*           - Example: `permission.Contains("Admin")` would return//?:-->True
*/


using System;

namespace Permissions_Challenge
{
    class Program
    {

        /**
         * <summary>
         * Monitors levels of authority and only allows access to those with appropriate clearance to certain features.
         * </summary>
         */
        static void Main()
        {
            string permission = "Admin|Manager";
            //~ Title associated with certain numeric levels organized as a The Company hierarchy.
            Random level = new();

            int Clearance = level.Next(1, 100);
            //~ Level of authority clearance loosely based upon longstanding trust & loyalty to The Company.
            Console.WriteLine($"Level of authority clearance: {Clearance}");

            if (permission.Contains("Admin"))
            {
                if (Clearance > 55)
                {
                    Console.WriteLine("Welcome, Super Admin user.");
                }
                else if (Clearance <= 55)
                {
                    Console.WriteLine("Welcome, Admin user.");
                }
            }
            else if (permission.Contains("Manager"))
            {
                if (Clearance >= 20)
                {
                    Console.WriteLine("Contact an Admin for access.");
                }
                else if (Clearance < 20)
                {
                    Console.WriteLine("You do not have sufficient privileges.");
                }
            }
            else
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }

        }
    }
}
