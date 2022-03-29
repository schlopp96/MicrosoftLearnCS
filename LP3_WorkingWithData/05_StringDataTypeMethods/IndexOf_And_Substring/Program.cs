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


ParenthesesIndex();
ContentsIndex();
ModifiedStartingValue();
ExtractHardcodeVals();