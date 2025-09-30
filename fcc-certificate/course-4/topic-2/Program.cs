// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
using System.Net;

string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

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

// Switch Expression forma alternativa e condensada de usar Switch em C#
size = product[2] switch
{
  "S" => "Small",
  "M" => "Medium",
  "L" => "Large",
  _ => "One Size Fits All",
};

Console.WriteLine($"Product: {size} {color} {type}");