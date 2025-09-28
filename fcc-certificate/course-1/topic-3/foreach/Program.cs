string[] names = ["Rowena", "Robin", "Bao"];
foreach (string name in names)
{
  Console.WriteLine(name);
}

int[] inventory = [200, 450, 700, 175, 250];
int sum = 0;
int bin = 0;
foreach (int item in inventory)
{
  sum += item;
  bin++;
  Console.WriteLine($"Bin {bin} = {item} (Running Total: {sum})");
}
Console.WriteLine($"We have {sum} items in the inventory");


