Random dice = new();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Jogada dos dados: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
{
  if ((roll1 == roll2) && (roll2 == roll3))
  {
    Console.WriteLine("Trinca! +6 bonus ao total!");
    total += 6;
  }
  else
  {
    Console.WriteLine("Par! +2 bonus ao total!");
    total += 2;
  }
}

if (total >= 16)
{
  Console.WriteLine("Você ganhou um carro novo!");
}
else if (total >= 10)
{
  Console.WriteLine("Você ganhou um notebook novo!");
}
else if (total == 7)
{
  Console.WriteLine("Você ganhou uma viagem!");
}
else
{
  Console.WriteLine("Você ganhou um gatinho!");
}