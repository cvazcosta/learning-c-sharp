Random coin = new();
string result = coin.Next(2) == 0 ? "Heads" : "Tails";
Console.WriteLine($"Result: {result}");

// Outra possível solução

// Random coin = new Random();
// int flip = coin.Next(0, 2);
// Console.WriteLine((flip == 0) ? "heads" : "tails");