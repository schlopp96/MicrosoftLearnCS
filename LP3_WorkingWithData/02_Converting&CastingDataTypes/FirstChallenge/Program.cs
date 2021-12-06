/*
        @- First Challenge -@
        !- 11/15/21 -!
> This module will feature two code challenges.
> This first challenge forces you to split up the data depending on its type and either concatenate or add the data accordingly.

    ^ Iterate through each value in a string of values.
    ^ Start with the following line of code:
        ?- string[] values = { "12.3", "45", "ABC", "11", "DEF" };

    ^ Add all the code necessary to implement the following business rules:

        $ Business Rules:

            & Rule 1: If the value is alphanumeric, concatenate it to form a message
            & Rule 2: If the value is numeric, add it to the total
            & Rule 3: Make sure the result matches the following output:
                > Message: ABCDEF
                > Total: 68.3

*/
static void FirstChallenge()
{

    string[] values = { "12.3", "45", "ABC", "11", "DEF" };

    decimal total = 0m;
    string message = "";

    foreach (string val in values)
    {
        if (Decimal.TryParse(val, out Decimal number))
        {
            total += number;
        }
        else
        {
            message += val;
        }
    }
    Console.WriteLine($"Message: {message}");
    Console.WriteLine($"Total: {total}");
}

FirstChallenge();