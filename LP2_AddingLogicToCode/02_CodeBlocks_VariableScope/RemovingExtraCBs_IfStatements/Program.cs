/*
* Remove EXTRA Code Blocks in If Statements *

^ - Readability is more important than "looks".
^ - If the code block needs only one line of code, chances are you don't need to define a formal code block using curly braces.
^        - Nor do you need to separate your code into multiple lines.

! RECAP !

^   - If you realize you only have one line of code in a code block, you can remove the curly braces and white space.
^   - Only remove code blocks when it makes the code more readable.
^   - Only remove the line feed if it makes the code more readable.
*/

using System;

namespace RemovingExtraCBs_IfStatements
{
    class Program
    {
        static void Main()
        {
            IfStatements.LongBlock();
            IfStatements.ShortBlock();
            IfElseStatements.IfElseNoCBs();
            IfElseStatements.IfElseNoCBs2();
        }
    }
}

class IfStatements
{
    public static bool LongBlock()
    {
        Console.WriteLine("\nLong 'If-Statement' Example:\n\nbool flag = true;\nif (flag)\n{\n  Console.WriteLine(flag);\n}\n! OUTPUT !:\n");
        bool flag = true;
        if (flag)
        {
            Console.WriteLine(flag);
        }
        return flag;
    }
    public static bool ShortBlock()
    {
        Console.WriteLine("\nModified SHORT 'If-Statement' Example:\n\nbool flag = true;\nif (flag) Console.WriteLine(flag);\n\n! OUTPUT: !\n");
        bool flag = true; //& Since we're merely executing a single line of code if the flag is true, we can remove the curly braces.
        if (flag) Console.WriteLine(flag); //! Since both the if statement and the method call are short, we can combine them into a single line.
        return flag;
    }
}

class IfElseStatements
{
    public static void IfElseNoCBs()
    {
        string name = "steve";
        if (name == "bob") Console.WriteLine("Found Bob");
        else if (name == "steve") Console.WriteLine("Found Steve");
        else Console.WriteLine("Found Chuck");
    }
    public static void IfElseNoCBs2()
    {
        string name = "steve";
        if (name == "bob")
            Console.WriteLine("Found Bob");
        else if (name == "steve")
            Console.WriteLine("Found Steve");
        else Console.WriteLine("Found Chuck");
    }
}