/*
>           String Formatting Basics
<                   1/16/21
^ - In this unit, we'll learn how to format strings to display this information accurately and more succinctly than string concatenation.

%           What is Composite Formatting?
$ - Composite formatting uses numbered placeholders within a string.
$ - At run time, everything inside the braces will be resolved to a value that is also passed in based on their position.
*   - See `CompositeFormatting()` method for example.
@       A few observations about these examples:
!- In the case of the first Console.WriteLine() statement, you can see that the tokens can be arranged in any order. Here, we have {1} before {0}.
!- In the case of the second Console.WriteLine() statement, you can see that the tokens can be reused and even omit the variable arguments that are passed in.

~           What is string interpolation?
& - String interpolation is a newer technique that simplifies composite formatting.
& - If you look at code examples in books and online, you're likely to see both techniques used, but generally you should prefer string interpolation.
& - Instead of using a numbered token and including the literal value or variable name in a list of arguments to String.Format() or Console.WriteLine(), you can just use the variable name inside of the curly braces.
& - In order for a string to be interpolated, you must prefix it with the $ directive.
* - CompositeFormattingEX()` method for example.
* - See `StringInterpolationEX()` method for example.
*/

static void CompositeFormattingEX()
{
    Console.Write("\nPlease enter first name:\n> ");
    string fname = Console.ReadLine();

    Console.Write("Please enter last name:\n> ");
    string lname = Console.ReadLine();


    Console.WriteLine("{1} {0}!", fname, lname);
}

static void StringInterpolationEX()
{
    Console.Write("Please enter first name:\n> ");
    string? fname = Console.ReadLine();

    Console.Write("Please enter last name:\n> ");
    string? lname = Console.ReadLine();

    Console.WriteLine($"{fname} {lname}!", fname, lname);
}

static void ChooseEX()
{

    Console.Write("Which string formatting example would you like to see?\n\n1.) Composite Formatting\n2.) String Interpolation\n> ");
    int uChoice = Console.Read();
    if (uChoice == '1')
    {
        CompositeFormattingEX();
    }
    else if (uChoice == '2')
    {
        StringInterpolationEX();
    }
    else
    {
        Console.WriteLine($"ERROR:\n{uChoice} not a valid entry.\nMust only enter (without quotes) \"1\" or \"2\".");
    }
}

ChooseEX();