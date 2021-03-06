/*
                    % CHALLENGE %
                * Started: 2/12/22 *
                ! Finished: 2/12/22 !

< At the beginning of this module, we described the scenario of working for a marketing department of a financial services company.
>To promote the company's newest investment products, we'll send thousands of personalized letters to our company's existing clients.
@ Our job is to write C# code that will merge personalized information about the customer.
? The letter will contain information such as:
    !- Existing portfolio
    $- Will compare their current returns to projected returns if they were to invest in using our new products.

* Our writers have decided on the following example marketing copy. Here's the desired output (using fictitious customer account data):

        > Dear Mr. Jones,
        > As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

        > Currently, you own 2,975,000.00 shares at a return of 12.75 %.

        > Our new product, Glorious Future offers a return of 13.13 %.  Given your current volume, your potential profit would be ¤63,000,000.00.

        > Here's a quick comparison:

            % Magic Yield         12.75 %   ¤55,000,000.00
            % Glorious Future     13.13 %   ¤63,000,000.00

^ Use your new found knowledge of string formatting to build an application that can merge and format the appropriate content given the example output above.
    <- Pay particular attention to the white space and make sure you accurately represent this exact format using C#.

& Here are the rules for the challenge:

~   1. Use the .NET Editor to generate the message given the variables and code.
@        - Replace the code comments with your own string formatting code.
~   2. You may not delete any of the existing code except for the comments.
*/

Console.Write("Enter name of letter recipient:\n> ");
string customerName = Console.ReadLine();

Console.Write("Enter name of old product:\n> ");
string currentProduct = Console.ReadLine();
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

Console.Write("Enter name of new product:\n> ");
string newProduct = Console.ReadLine();
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

//-> Your logic here
string message = $"Dear {customerName},\nAs a customer of our {currentProduct} offering we are exited to tell you about a new financial product that would dramatically increase your return.\n\nCurrently you own {currentShares:n2} shares at a return of {currentReturn:p2}.\n\nOur new product, {newProduct} offers a return of {newReturn:p2}.  Given your current volume, your potential profit would be {newProfit:C}.\n\n";
Console.Write(message);

//-> Your logic here:

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = $"{currentProduct,-8}         {currentReturn:p2}   {currentProfit:C}\n{newProduct,-4}     {newReturn:p2}   {newProfit:C}";

Console.WriteLine(comparisonMessage);
