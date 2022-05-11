/*

>               Challenge
< In this challenge, you'll work with a string that contains a fragment of HTML.
< You'll extract data from the HTML fragment, replace some of its content, and remove other parts of its content to achieve the desired output.

& Given the starting point in the following code listing, you'll add code to extract, replace, and remove portions of the input's value to produce the desired output.

* const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
*
* string quantity = "";
* string output = "";
*
* // Your work here
*
* Console.WriteLine(quantity);
* Console.WriteLine(output);

& The following listing is the desired output once you've modified the code in the starting point:
* Quantity: 5000
* Output: <h2>Widgets &reg;</h2><span>5000</span>

^ You may only add code to the starting point code listing. You must not change the variable declarations.
^ All of your work should go under the comment // Your work here.
^
^ You'll perform three operations on the input using the tools and techniques you learned in this module.
^
^ Set the quantity variable to the value you extract from between the <span> and </span> tags.
^ Set the output variable to the value of input, then remove the <div> and </div> tags.
^ Replace the HTML character &trade; with &reg; in the output variable.

*/

static void challenge()
{
    const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
    string quantity = "";
    string output = "";
    // My Work Below:

    int spanStart = input.IndexOf("<span>");
    int spanEnd = input.IndexOf("</span>");
    quantity = input.Substring(spanStart + 6, spanEnd - spanStart - 6);

    int divStart = input.IndexOf("<div>");
    int divEnd = input.IndexOf("</div>");
    output = input.Substring(divStart + 5, divEnd - divStart - 5);

    output = output.Replace("&trade;", "&reg;");

    Console.WriteLine(quantity);
    Console.WriteLine(output);
}

challenge();