/*
?       Using Switch-Case Statement to Branch Flow of Code      ?

^       What is the "switch" statement?        ^
* - switch is a selection statement that chooses a single switch section to execute from a list of candidates.
!       - Candidates are chosen based on a pattern match with the match expression.
?       - includes one or more switch sections.
?       - Each switch section contains one OR MORE case label (either a case or default label) followed by one or more statements.

&       Switch is best used when:       &
!       - you have a single value you want to match against many possible values
!       - but for any given match, you need to execute a couple of lines of code at most
!       - It's possible that multiple cases apply, however C# will select the first matching expression.

&                                   ^           RECAP           ^
* - Use the switch statement when you have one value with many possible matches;
!                               - each match requiring a separate branch in your code logic.
* - A single switch section containing code logic can be matched using one or more labels defined by the case keyword.
* - Use the optional default keyword to create a label and a switch section to be used when no other case labels match.
*/

using System;

namespace UsingSwitchCase
{
    class Program
    {
        static void Main()
        {
            int employeeLevel = 100;
            string employeeName = "John Smith";

            string title;

            switch (employeeLevel)
            {
                case 100:
                case 200:
                    title = "Senior Associate";
                    break;
                case 300:
                    title = "Manager";
                    break;
                case 400:
                    title = "Senior Manager";
                    break;
                default:
                    title = "Associate";
                    break;
            }
            Console.WriteLine($"{employeeName}, {title}");
        }
    }
}
