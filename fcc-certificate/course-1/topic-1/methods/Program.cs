Random dice = new();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);
dice.Next(7);

Console.WriteLine(roll1);
Console.WriteLine(roll2);
Console.WriteLine(roll3);

int firstValue = 500;
int secondValue = 600;
int largerValue;

largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);