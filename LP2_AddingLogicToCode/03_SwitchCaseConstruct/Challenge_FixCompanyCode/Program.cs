/*
^   Challenge: Fixing Company Code
^      - Look up product by SKU
? - Suppose we work for a souvenir shop in a college town that sells t-shirts, sweatshirts, etc.
? - We've been asked to rewrite certain portions of the code to make it more readable.
? - A monthly sales report uses the full description as well as the Stock Keeping Unit (SKU) of the products sold.
? - One of the tasks is to simplify the conversion of a SKU into a description using the switch statement.

! Rewrite the following code to use switch-case statements instead of if-elseif-else: !
?    SKU = Stock Keeping Unit:
^    string sku = "01-MN-L";
^
^    string[] product = sku.Split('-');
^
^    string type = "";
^    string color = "";
^    string size = "";
^
^    if (product[0] == "01")
^    {
^        type = "Sweat shirt";
^    } else if (product[0] == "02")
^    {
^        type = "T-Shirt";
^    } else if (product[0] == "03")
^    {
^        type = "Sweat pants";
^    }
^    else
^    {
^        type = "Other";
^    }
^
^    if (product[1] == "BL")
^    {
^        color = "Black";
^    } else if (product[1] == "MN")
^    {
^        color = "Maroon";
^    } else
^    {
^        color = "White";
^    }
^
^    if (product[2] == "S")
^    {
^        size = "Small";
^    } else if (product[2] == "M")
^    {
^        size = "Medium";
^    } else if (product[2] == "L")
^    {
^        size = "Large";
^    } else
^    {
^        size = "One Size Fits All";
^    }
^
^    Console.WriteLine($"Product: {size} {color} {type}");

* No matter how you do it, your code should output:

*/

using System;

namespace Challenge_FixCompanyCode
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter [1] to run \"OriginalCode();\"\nEnter [2] to run \"FixedCode();\"\nEnter [3] to run \"SwitchCase_AdvancedSyntax();\"");
            string user_choice = Console.ReadLine();
            switch (user_choice[0])
            {
                case '1':
                    OriginalCode();
                    break;
                case '2':
                    Solution();
                    break;
                case '3':
                    ExtraCredit();
                    break;
                default:
                    Console.WriteLine($"Sir, {user_choice} is not a valid choice.\nIf you're REALLY that stupid, you should just put your helmet back on, and fuck off :)");
                    break;
            }

            static void OriginalCode()
            {

                //& SKU = Stock Keeping Unit
                string sku = "01-MN-L";

                string[] product = sku.Split('-');

                string type;
                string color;
                string size;

                if (product[0] == "01") // ! Replace With Switch-Case
                {
                    type = "Sweat shirt";
                }
                else if (product[0] == "02")
                {
                    type = "T-Shirt";
                }
                else if (product[0] == "03")
                {
                    type = "Sweat pants";
                }
                else
                {
                    type = "Other";
                }
                if (product[1] == "BL") // ! Replace With Switch-Case
                {
                    color = "Black";
                }
                else if (product[1] == "MN")
                {
                    color = "Maroon";
                }
                else
                {
                    color = "White";
                }
                if (product[2] == "S") // ! Replace With Switch-Case
                {
                    size = "Small";
                }
                else if (product[2] == "M")
                {
                    size = "Medium";
                }
                else if (product[2] == "L")
                {
                    size = "Large";
                }
                else
                {
                    size = "One Size Fits All";
                }
                Console.WriteLine($"Product: {size} {color} {type}");
            }


            static void Solution()
            {
                //& SKU = Stock Keeping Unit
                string sku = "01-MN-L";

                //@ Assign each resulting string (from splitting `sku` at each "-") to an array:
                string[] product = sku.Split('-');

                string type;
                string color;
                string size;

                switch (product[0])
                {
                    case "01":
                        type = "Sweat shirt";
                        break;
                    case "02":
                        type = "T-Shirt";
                        break;
                    case "03":
                        type = "Sweat pants";
                        break;
                    default:
                        type = "Other";
                        break;
                }
                switch (product[1])
                {
                    case "BL":
                        color = "Black";
                        break;
                    case "MN":
                        color = "Maroon";
                        break;
                    default:
                        color = "White";
                        break;
                }

                switch (product[2])
                {
                    case "S":
                        size = "Small";
                        break;
                    case "M":
                        size = "Medium";
                        break;
                    case "L":
                        size = "Large";
                        break;
                    default:
                        size = "One Size Fits All";
                        break;
                }
                Console.WriteLine($"Product: {size} {color} {type}");
            }

            static void ExtraCredit()
            {

                //$ SKU = Stock Keeping Unit:
                Console.WriteLine("Please Enter Product SKU Identification:");
                string skuInput = Console.ReadLine();

                //@ Assign each resulting string (from splitting `skuInput` at each "-") to an array:
                string[] productID = skuInput.Split('-');

                //^ Assign array index to matching case:
                string type = productID[0] switch
                {
                    "01" => "Sweat shirt",
                    "02" => "T-Shirt",
                    "03" => "Sweat pants",
                    _ => "Other",
                };

                //^ Assign array index to matching case:
                string color = productID[1] switch
                {
                    "BL" => "Black",
                    "MN" => "Maroon",
                    _ => "White",
                };

                //^ Assign array index to matching case:
                string size = productID[2] switch
                {
                    "S" => "Small",
                    "M" => "Medium",
                    "L" => "Large",
                    _ => "One Size Fits All",
                };
                Console.WriteLine($"Product: {size} {color} {type}");
            }
        }
    }
}
