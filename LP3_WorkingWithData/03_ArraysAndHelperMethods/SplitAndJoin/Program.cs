/*
        < Split() and Join() >
        ! 12.2.2021 !

>- Suppose you work for a system integrator.
>- You're building a series of small programs that will:
    < 1.take data from one partner's system
    < 2. modify the data
    < 3. pass it to an internal system in the format it requires.

>- To perform this transformation on the data, you'll need to:
    < 1. accept incoming data as a string
    < 2. parse it into smaller data elements
    < 3. manipulate it to match a different format.

?- But how can you parse the string data into "smaller data elements"?

        ^ String Data Type's Array Methods ^

>- The variables of type string have many built-in methods that convert a single string into either an array of smaller strings, or an array of individual characters.
>- When processing data from other computer systems, sometimes it's formatted or encoded in a way that's not useful for your purposes.
>- In those cases, you can use the string data type's Array methods to parse a larger string into an array.

        @ RECAP @
    ^ Here's a few things to remember when working with strings and arrays:

    & There's several methods and techniques that allow you to convert a string to an array, and from an array to a string

    $ Use methods like ToCharArray() and Split() to create an array

    ! Use methods like Join(), or create a new string passing in an array of char to turn the array back into a single string


*/



Step1And2();
Steps3And4();


static void Step1And2()
{
    // @ Step 1
    Console.WriteLine("\nHere we're using the `ToArray()` string method to create an array of `char`s,\neach element of the array has one character of the string.\n\nstring value = 'abc123';\nchar[] valuearray = value.ToCharArray();\n");

    string value = "abc123";
    char[] valueArray = value.ToCharArray();
    Console.WriteLine($"\nLength of new array: {valueArray.Length}\n");

    // @ Step 2
    Console.WriteLine("\nNext, we'll reverse the order of the chars in the array, then use the Write method to combine them back into a single output.\n\nArray.Reverse(valueArray);\nstring result = new string(valueArray);\nConsole.WriteLine(result);\n\nOutput:");

    Array.Reverse(valueArray);
    string result = new(valueArray); //%: Creates new string-class instance from array: `valueArray` array.
    Console.WriteLine(result);

    Console.WriteLine("\nThe expression new string(valueArray) creates a new empty instance of the System.String class (which is the same as the string data type in C#) and passes in the char array as a constructor.\n");

}


static void Steps3And4()
{

    // @ Step 3

    Console.WriteLine("\nPerhaps we need to separate each element of the char array using a comma, as is common when working with data that is represented as ASCII text.\nTo do that, we'll comment out the line of code we added in Step 2 and use the String class' Join() method, passing in the char we want to delimit each segment (the comma) and the array itself.\n\nstring value = 'abc123';\nchar[] valueArray = value.ToCharArray();\nArray.Reverse(valueArray);\n// string result = new string(valueArray);\nstring result = String.Join(',', valueArray);\nConsole.WriteLine(result); \n\nOutput:");

    string value = "abc123";
    char[] valueArray = value.ToCharArray();
    Array.Reverse(valueArray);
    // string result = new string(valueArray);
    string result = String.Join(",", valueArray);
    Console.WriteLine(result);

    // @ Step 4
    Console.WriteLine("\nFinally, let's use the Split() method available to variables of type string to create an array of strings.\nWe'll use the comma as the delimiter to split one long string into smaller strings.\nFinally, we'll loop through each element of the new array of string.\n\nstring[] items = result.Split('\nabc123');\nforeach (string item in items)\n{\n\tConsole.WriteLine(item);\n}\n\nOutput:");

    string[] items = result.Split(',');
    foreach (string item in items)
    {
        Console.WriteLine(item);
    }
}



