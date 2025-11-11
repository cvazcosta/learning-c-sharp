using System.Globalization;

// Definindo a cultura padrão do programa para en-US
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-US");

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"\tShares: {productShares:N3} Product");
Console.WriteLine($"\t\tSub Total: {subtotal:C}");
Console.WriteLine($"\t\tTax: {taxPercentage:P2}");
Console.WriteLine($"\t\tTotal Billed:: {total:C}");

// Aprendendo sobre padding
string input = "Pad this";
Console.WriteLine(input.PadRight(12));

// Outro overload do Pad
Console.WriteLine(input.PadLeft(24, '-'));
Console.WriteLine(input.PadRight(24, '-'));

// Trabalhando com padded strings
string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);