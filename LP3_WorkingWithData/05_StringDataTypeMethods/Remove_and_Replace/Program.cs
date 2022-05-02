/*
*     s          Remove and Replace
~                   3/28/2022

!       Remove()
< You would typically use Remove() when there's a standard and consistent position of the characters you want to remove from the string.

> Sometimes, data stored in older files is fixed length, where character positions are allocated for certain fields of information.
^ In this first step of our exercise, we have such a fictitious record of information.
@       - The first five digits represent a customer identification number.
$       - The next 20 digits contain a customer's name.
%       - The next six positions represent the customer's latest invoice amount
&       - The last three positions represent the number of items ordered on that invoice.

? Since we know the exact position and length of the user's name, we can easily remove it using the Remove() method.

@       Replace()
<You would use the Replace() method when you must replace one or more characters with a different character (or no character).

? The Replace() method is different from the other methods we've used so far as it will replace every instance of the given characters, not just the first or last instances.

*       Recap
< Here's the most important things to remember from this unit:

> The Remove() method works like the Substring() method, except that it deletes the specified characters in the string.
$ The Replace() method swaps all instances of a string with a new string.

*/
/*
@       -The first five digits represent a customer identification number.
$       - The next 20 digits contain a customer's name.
%       - The next six positions represent the customer's latest invoice amount
&       - The last three positions represent the number of items ordered on that invoice.
*/


static void Ex_Remove()
{
    string data = "12345John Smith          5000  3  ";
    Console.WriteLine($"Starting Data:\n\n>> {data}");

    string updatedData = data.Remove(5, 20); // Remove ID number & customer name.
    Console.WriteLine($"\nExtracted invoice number & items ordered:\n\n>> {updatedData}\n"); // Output invoice amount & number of items ordered.

}

static void Ex_Replace()
{
    string message = "This--is--ex-amp-le--da-ta";
    Console.WriteLine($"Starting Data:\n\n>> {message}");
    message = message.Replace("--", " "); // Replace "--" with a space.
    message = message.Replace("-", ""); // Replace "-" with a space.
    Console.WriteLine($"\nReplaced \"--\" and \"-\" characters with spaces:\n\n>> {message}\n");
}

static void main()
{
    Ex_Remove();
    Ex_Replace();
}

main();