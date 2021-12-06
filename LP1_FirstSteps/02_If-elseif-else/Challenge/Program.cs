/*
* 8/12/21
* Microsoft If-ElseIf-Else Module Challenge

! Start With this code:

    & Random random = new Random();
    & int daysUntilExpiration = random.Next(12);
    & int discountPercentage = 0;

    & Your code goes here

? Rule 1. If the user's subscription will expire in 10 days or less, display the message:
    & Your subscription will expire soon. Renew now!

? Rule 2. If the user's subscription will expire in five days or less, display the messages:
    & Your subscription expires in _ days.
    & Renew now and save 10%!
    ! - Make sure to substitute "_" for the value stored in the variable daysUntilExpiration.

? Rule 3. If the user's subscription will expire in one day, display the message:
    & Your subscription expires within a day!
    & Renew now and save 20%!

? Rule 4. If the user's subscription has expired, display the message:
    & Your subscription has expired.

? Rule 5. If the user's subscription doesn't expire in 10 days or less, display nothing.
*/
using System;

namespace Challenge
{
    class Program
    {
        static void Main()
        {
            // ^ Create RNG `daysUntilExpiration` for dynamic results for testing:
            Random random = new();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage;

            Console.WriteLine($"Checking subscription...");

            //* Rule 1:
            if (daysUntilExpiration == 0)
            {
                Console.WriteLine("Your subscription has expired.");

            }
            else if (daysUntilExpiration == 1)
            {
                discountPercentage = 20;
                Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
            }
            else if (daysUntilExpiration <= 5)
            {
                discountPercentage = 10;
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
            }
            else if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subscription will expire soon. Renew now!");
            }
            else
            {
                Console.WriteLine($"Your subscription is active!");
            }
        }
    }
}
