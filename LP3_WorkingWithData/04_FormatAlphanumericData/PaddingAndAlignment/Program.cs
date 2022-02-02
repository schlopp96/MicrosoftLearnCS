/*
~           Padding & Alignment          ~
&               2/1/22                  &

> There are many similar methods on the string data type as well as any literal string or variable of type string.

> Here's a brief list of categories of these built-in methods so you can get an idea of what's possible:

<  - Methods that either add blank spaces for formatting purposes (PadLeft(), PadRight())
<  - Methods that either compare two strings or facilitate comparison (Trim(), TrimStart(), TrimEnd(), GetHashcode(), the Length property)
<  - Methods that help you determine what's inside of a string, or even retrieve just a part of the string (Contains(), StartsWith(), EndsWith(), Substring())
<  - Methods that change the content of the string by replacing, inserting, or removing parts (Replace(), Insert(), Remove())
<  - Methods that turn a string into an array of strings or characters (Split(), ToCharArray())

>  - We'll use these methods in other modules as we find a use for their functionality.

*           Exercise - Working with Padded Strings          *

$ Suppose we work for a payment processing company that still supports legacy mainframe systems.
$ Often, those systems require data to be input in specific columns.
$ For example:
?   - The Payment ID should be stored in columns 1 through 6,
?   - ....the payee's name in columns 7 through 30
?   - and the Payment Amount in columns 31 through 40.
?   - Also, importantly, the Payment Amount should be right-aligned.

$ We are asked to build an application that will convert data in our relational database management system to the legacy file format.
$ To ensure that the integration will work correctly, our first step is to confirm the file format by giving the legacy system maintainers a sample of our output.
$ Later, we'll build on this work to send hundreds or thousands of payments to be processed via an ASCII text file.

@           Recap           @
< - The string data type, literal strings, and variables of type string each implement many helper methods to format, modify, and perform other operations on strings.
< - The PadLeft() and PadRight() methods add white space (or optionally, another character) to the total length of a string.
< - Use PadLeft() to right-align a string.
< - Some methods are overloaded, meaning they have multiple versions of the method with different arguments that affect their functionality.
< - The += operator concatenates a new string on the right to the existing string on the left.

*/

string paymentId = "769";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);