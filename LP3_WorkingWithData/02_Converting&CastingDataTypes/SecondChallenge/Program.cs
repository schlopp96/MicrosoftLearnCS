/*
        @- Second Challenge -@
        &- 11/17/2021 -&

$- The following challenge will force you to understand the implications of casting values considering the impact of narrowing and widening conversions.

> Start with the following code:

    ^- int value1 = 12;
    ^- decimal value2 = 6.2m;
    ^- float value3 = 4.3f;

    // Your code here to set result1
    ^- Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

    // Your code here to set result2
    ^- Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

    // Your code here to set result3
    ^- Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

> Replace the code comments with your own code to solve the challenge.
> When you run your code, you should see the following output:

    ^ Divide value1 by value2, display the result as an int: 2
    ^ Divide value2 by value3, display the result as a decimal: 1.4418604651162790697674418605
    ^ Divide value3 by value1, display the result as a float: 0.3583333
*/

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = value1 / (int)value2;
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
