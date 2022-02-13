/*
>           String Formatting Basics
<               Started: 1/16/22
<               Finished: 2/1/22
>             Last Edited: 2/12/22

^ - In this unit, we'll learn how to format strings to display this information accurately and more succinctly than string concatenation.


%           What is Composite Formatting?
$ - Composite formatting uses numbered placeholders within a string.
$ - At run time, everything inside the braces will be resolved to a value that is also passed in based on their position.
*   - See `CompositeFormatting()` method for example.
@       A few observations about these examples:
!- In the case of the first Console.WriteLine() statement, you can see that the tokens can be arranged in any order. Here, we have {1} before {0}.
!- In the case of the second Console.WriteLine() statement, you can see that the tokens can be reused and even omit the variable arguments that are passed in.


<           What is string interpolation?
% - String interpolation is a newer technique that simplifies composite formatting.
% - If you look at code examples in books and online, you're likely to see both techniques used, but generally you should prefer string interpolation.
% - Instead of using a numbered token and including the literal value or variable name in a list of arguments to String.Format() or Console.WriteLine(), you can just use the variable name inside of the curly braces.
% - In order for a string to be interpolated, you must prefix it with the $ directive.
*   - CompositeFormattingEX()` method for example.
*   - See `StringInterpolationEX()` method for example.


@           Formatting Currency             @
> Composite formatting and string interpolation can be used to format values for display given a specific language and culture.
> In the `FormattingCurrencyEX()` method example, the ":C" currency format specifier is used to present the price and discount variables as currency.
> Note that adding the ":C" to the tokens inside of the curly braces formats the number as currency regardless of whether you use int or decimal.


^           Definition of Localization:             ^
! Making sure your code works correctly on all computers regardless of the country or the end user's language


*           Formatting Numbers              *
^ When working with numeric data, you may want to format the number for readability by including commas to delineate thousands, millions, billions, and so on.
^   - The "N" numeric format specifier will do this.
^   - By default, the N numeric format specifier displays only two digits after the decimal point.
<       - To display more precision, add a number after the specifier:
$            decimal measurement = 123456.78912m;
$            Console.WriteLine($"Measurement - {measurement:N4} units.")
&            Output:
&            Measurement - 123456.7891 units.


?           Formatting Percentages          ?
~ Use the "P" format specifier to format percentages.
~   - Again, add a number afterwards to control number of values displayed after decimal point.


>               Recap               <
* Here are most important takeaways from this unit about string formatting:

< - You can use composite formatting or string interpolation to format strings.
< - With composite formatting, you use a string template containing one or more replacement tokens in the form {0}. You also supply a list of arguments that are matched with the replacement tokens based on their order. Composite formatting works when using string.Format() or Console.WriteLine().
< - With string interpolation, you use a string template containing the variable names you want replaced surrounded by curly braces. Use the $ directive before the string template to indicate you want the string to be interpolated.
< - Format currency using a :C specifier.
< - Format numbers using a :N specifier. Control the precision (number of values after the decimal point) using a number after the :N like {myNumber:N3}.
< - Formatting currency and numbers depends on the end user's culture, a five character code that includes the user's country and language (per the settings on their computer).
*/

static void CompositeFormattingEX()
{
    Console.Write("\nPlease enter first name:\n=> ");
    string? fname = Console.ReadLine();

    Console.Write("\nPlease enter last name:\n=> ");
    string? lname = Console.ReadLine();


    Console.WriteLine("\nWelcome, esteemed Lord {0} of the {1} fortune!", char.ToUpper(fname![0]) + fname[1..], char.ToUpper(lname![0]) + lname[1..]);
}

static void StringInterpolationEX()
{
    Console.Write("\nPlease enter first name:\n=> ");
    string? fname = Console.ReadLine();

    Console.Write("\nPlease enter last name:\n=> ");
    string? lname = Console.ReadLine();

    Console.WriteLine($"\nAhh! Mr. {lname}! Long cock no see, my good friend \"Needle-Dick-{fname}\"!", char.ToUpper(fname![0]) + fname[1..], char.ToUpper(lname![0]) + lname[1..]);
}

static void FormattingCurrencyEX()
{
    while (true)
    {
        Console.Write("\nPlease enter a price:\n=> ");
        string? price = Console.ReadLine();
        int discount = 50;
        if (decimal.TryParse(price, out decimal finalPrice))
        {
            Console.WriteLine($"\nPre-total: {finalPrice:C}\nDiscount: -{discount:C}\nFinal Price: {finalPrice - 50:C}");
            break;
        }
        else { Console.WriteLine($"\nNOPE!! The fuck is \"{price}\"???\n\nYA FUCKED UP, RETARD!!\n"); }
    }
}

static void FormattingNumbersEX()
{
    while (true)
    {
        Console.Write("\nPlease enter a number:\n=> ");
        string? measurement = Console.ReadLine();
        if (decimal.TryParse(measurement, out decimal final))
        {
            Console.WriteLine($"\nMeasurement: {final:N4} units.");
            break;
        }
        else { Console.WriteLine($"\nNOPE!! The fuck is \"{measurement}\"???\n\nYA FUCKED UP, RETARD!!\n"); }
    }
}

static void FormattingPercentagesEX()
{
    while (true)
    {
        Console.Write("\nPlease enter a percentage with atleast 2 decimal places.\nEx: 0.44\n=> ");
        string? inp = Console.ReadLine();
        if (decimal.TryParse(inp, out decimal percentage))
        {
            Console.WriteLine($"\nTax rate: {percentage:P4}");
            break;
        }
        else { Console.WriteLine($"\nNOPE!! The fuck is \"{inp}\"???\n\nYA FUCKED UP, RETARD!!\n"); }
    }
}

static void ChooseEX()
{
    while (true)
    {
        Console.Write("\nWhich string formatting example would you like to see?\n\n1.) Composite Formatting\n2.) String Interpolation\n3.) Currency Formatting\n4.) Number Formatting\n5.) Percentage Formatting\n6.) Exit\n=> ");
        string? uChoice = Console.ReadLine();
        if (uChoice == "1")
        {
            CompositeFormattingEX();
        }
        else if (uChoice == "2")
        {
            StringInterpolationEX();
        }
        else if (uChoice == "3")
        {
            FormattingCurrencyEX();
        }
        else if (uChoice == "4")
        {
            FormattingNumbersEX();
        }
        else if (uChoice == "5")
        {
            FormattingPercentagesEX();
        }
        else if (uChoice == "6")
        {
            Console.WriteLine("\nExiting Program...");
            break;
        }
        else
        {
            Console.WriteLine($"\n!! INPUT ERROR: !!\n\"{uChoice}\" not a valid entry.\nMust only enter (without quotes) numbers between \"1\" - \"6\".\n\nPress [ENTER] to continue.\n");
            Console.ReadKey(false);
        }
    }
}

ChooseEX();