using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-us");

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} at a return of {currentReturn:P2}");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit}.\n");
Console.WriteLine("Here's a quick comparison:\n");
// Console.WriteLine($"{currentProduct}\t\t{currentReturn:P2}\t\t{currentProfit:C}");
// Console.WriteLine($"{newProduct}\t\t{newReturn:P2}\t\t{newProfit:C}");

string comparisonMessage = "";

// Your logic here

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += string.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += string.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";

comparisonMessage += newProduct.PadRight(20);
comparisonMessage += string.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += string.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);
