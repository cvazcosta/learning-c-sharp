int heroHealthPoints = 10;
int monsterHealthPoints = 10;
int heroAttack, monsterAttack;

Random damage = new();

do
{
  heroAttack = damage.Next(1, 11);
  monsterHealthPoints -= heroAttack;
  Console.WriteLine($"The monster lost {heroAttack} health points!");

  if (monsterHealthPoints > 0)
  {
    Console.WriteLine($"The monster has {monsterHealthPoints} health points left!");
    monsterAttack = damage.Next(1, 11);
    heroHealthPoints -= monsterAttack;
    Console.WriteLine($"The hero lost {monsterAttack} health points!");
    if (heroHealthPoints > 0)
    {
      Console.WriteLine($"The hero has {heroHealthPoints} health points left!");
    }
    else
    {
      Console.WriteLine("The monster won!");
    }
  }
  else
  {
    Console.WriteLine("The hero won!");
  }

} while ((heroHealthPoints > 0) && (monsterHealthPoints > 0));

// Solução do manual

int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
  int roll = dice.Next(1, 11);
  monster -= roll;
  Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

  if (monster <= 0) continue;

  roll = dice.Next(1, 11);
  hero -= roll;
  Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");