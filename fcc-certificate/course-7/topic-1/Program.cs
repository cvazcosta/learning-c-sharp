// Criando um template por composite formatting
string first = "Hello";
string second = "World";
string result = string.Format("{1} {0}!", first, second);
string result_2 = string.Format("{0} {0} {0}!", first, second);
Console.WriteLine(result);
Console.WriteLine(result_2);

// Criando um template por string interpolation
string third = "Hail";
string fourth = "Durin";
Console.WriteLine($"{third}, {fourth}!");

// Formatando para moeda
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// Formatando números
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");

// Formatando percentuais
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

// Combinando abordagens
decimal price2 = 67.55m;
decimal salePrice = 59.99m;
string yourDiscount = string.Format("You saved {0:C2} off the regular {1:C2} price2.", (price2 - salePrice), price2);
yourDiscount += $"A discount of {((price2 - salePrice) / price2):P2}!";
Console.WriteLine(yourDiscount);
