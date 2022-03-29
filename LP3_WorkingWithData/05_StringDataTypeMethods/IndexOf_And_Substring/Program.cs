/*
                            ^ Using String-Helper-Methods IndexOf() & Substring() ^

? In this exercise, you'll use the IndexOf() method and its variants including:
&    IndexOf()
%    LastIndexOf()
~ to locate the position of one character or string inside a larger string.

< Once we've located the position, we can use the Substring() method to return the rest of the string after the position.

> Or we can use an overloaded version of the Substring() method to set the number of characters (length) to return after the position.

*/

//% Step 1: Find index of the two parenthesis.

static void ParenthesesIndex()
{

    string message = "Find what is (inside the parentheses)";

    int opening = message.IndexOf('(');
    int closing = message.IndexOf(')');

    Console.WriteLine($"Opening Parethesis Index: {opening}\n\n");
    Console.WriteLine($"Closing Parethesis Index: {closing}\n\n");
}

//$ Step 2 - Add code to retrieve the value between two parenthesis characters

static void ContentsIndex()
{

    string message = "Find what is (inside the parentheses)";

    int opening = message.IndexOf('(');
    int closing = message.IndexOf(')');

    //Console.WriteLine($"Opening Parethesis Index: {opening}\n\n");
    //Console.WriteLine($"Closing Parethesis Index: {closing}\n\n");

    int length = closing - opening;
    Console.WriteLine($"Result:\n\"{message.Substring(opening, length)}\"\n\n");
}

//! Step 3 - Update the code to modify the starting position of the sub string

static void ModifiedStartingValue()
{

    string message = "Find what is (inside the parentheses)";

    int opening = message.IndexOf('(');
    int closing = message.IndexOf(')');

    opening += 1;

    int length = closing - opening;
    Console.WriteLine($"Result:\n\"{message.Substring(opening, length)}\"\n\n");
}

//@ The reason we're using the value 1 is because that is the length of the character.
//& If we were attempting to locate a value starting after a longer string, for example, <div> or ---, we would use the length of that string instead.

//* The following snippet of code shows how to find the value inside an opening and closing <span> tag.

static void ExtractHardcodeVals()
{
    string message = "What is the value <span>between the tags</span>?";

    const string openSpan = "<span>";
    const string closeSpan = "</span>";

    int openingPosition = message.IndexOf(openSpan);
    int closingPosition = message.IndexOf(closeSpan);

    openingPosition += openSpan.Length;
    int length = closingPosition - openingPosition;

    Console.WriteLine($"Result:\n{message.Substring(openingPosition, length)}\n\n");
}

//! Step 4 - Write code to retrieve the last occurrence of a sub string
//? Next, let 's increase the complexity of the message variable by adding many sets of parentheses, then write code to retrieve the content inside the last set of parentheses.

static void LastSubString()
{
    string message = "(What if) I am (only interested) in the last (set of parentheses)?";
    int openingPosition = message.LastIndexOf('(');

    openingPosition += 1;
    int closingPosition = message.LastIndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}

//@ Step 5 - Update the code example to retrieve any value between one or more sets of parentheses in a string
//* This time, we'll update the message to have three sets of parentheses, and we'll write code to extract any text inside of them.

//& We'll be able to reuse portions of our previous work, but will
//& need to add a while statement to iterate through the string until
//& all sets of parentheses are discovered, extracted, and displayed.

static void ExtractParenthesisVals()
{
    string message = "(What if) there are (more than) one (set of parentheses)?";

    while (true)
    {
        int openingPosition = message.IndexOf('(');

        if (openingPosition == -1) break;

        openingPosition += 1; //Adjust index for index-offset of start of parentheses contents.
        int closingPosition = message.IndexOf(')');
        int messageLength = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, messageLength));

        //> Note how we use the overload of Substring to return only the remaining
        //> unprocessed message:
        message = message.Substring(closingPosition + 1);
    }
}

//% Step 6 - Update the code example to work with different types of symbol sets
//This time, we'll update the message string adding different types of symbols like square brackets and curly braces. We'll rely on IndexOfAny() to provide an array of characters representing the opening symbols. IndexOfAny() will return us the first match it finds in the string.

//< Once we find a symbol, we'll need to find its matching closing symbol.
//< Once we do that, the rest should look similar.
//< We'll use a different tactic instead of modifying the original value of message.
//< This time, we'll use the closing position of the previous iteration as the opening position of the current iteration.

static void ExtractSymbolContent()
{
    string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

    //* The IndexOfAny() helper method requires a char array of characters.
    //* We want to look for:

    char[] openSymbols = { '[', '{', '(' };

    //? We'll use a slightly different technique for iterating through the
    //? characters in the string. This time, we'll use the closing position
    //? of the previous iteration as the starting index for the next open
    //? symbol. So, we need to initialize the closingPosition variable
    //? to zero:

    int closingPosition = 0;

    while (true)
    {
        int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

        if (openingPosition == -1) break;

        string currentSymbol = message.Substring(openingPosition, 1);

        //! Now we must find the matching closing symbol
        char matchingSymbol = ' ';

        switch (currentSymbol)
        {
            case "[":
                matchingSymbol = ']';
                break;
            case "{":
                matchingSymbol = '}';
                break;
            case "(":
                matchingSymbol = ')';
                break;
        }

        //~ To find the closingPosition, we use an overload of the IndexOf method to specify
        //~ that our search for the matchingSymbol should start at the openingPosition in the string.

        openingPosition += 1;
        closingPosition = message.IndexOf(matchingSymbol, openingPosition);

        //@ Finally, use the techniques we've already learned to display the sub-string:

        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length));
    }
}
//                  $ Recap
// ~We covered a lot of ground in this unit. Here's the most important things to remember:
//
//* IndexOf() gives us the first position of a character or string inside of another string.
//! IndexOf() returns - 1 if it can't find a match.
//? Substring() returns just the specified portion of a string, using a starting position and optional length.
//@ LastIndexOf() returns the last position of a character or string inside of another string.
//^ IndexOfAny() returns the first position of an array of char that occurs inside of another string.
//& There's often more than one way to solve a problem. We used two separate techniques to find all instances of a given character or string.
//% Avoid hardcoded magic values. Instead, define a const variable. A constant variable's value can't be changed after initialization.

static void main()
{
    ParenthesesIndex();
    ContentsIndex();
    ModifiedStartingValue();
    ExtractHardcodeVals();
    LastSubString();
    ExtractParenthesisVals();
    ExtractSymbolContent();
}

main();