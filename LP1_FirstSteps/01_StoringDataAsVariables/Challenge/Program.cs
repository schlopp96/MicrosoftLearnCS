/*
~ Take First Steps with C# - Storing Data Lesson Challenge
! Write code in the .NET Editor to display a message.
* When you're finished, the message should resemble the following output:
^ Hello, Bob! You have 3 in your inbox.  The temperature is 34.4 celsius.
*/
using System;

namespace Challenge
{
    class Program
    {
        static void Main()
        {
            Console.Write("Welcome!\nPlease Enter Your Name:\n> ");
            string name = Console.ReadLine();
            int messages = 3;
            decimal temperature = 34.4m;
            Console.WriteLine($"Hello, {name}! You have {messages} messages in your inbox.\nThe temperature is {temperature} celsius.");
            Console.WriteLine("Press anything to continue...");
            Console.ReadKey(false);
        }
    }
}
