﻿Random random = new();
int daysUntilExpiration = random.Next(12);
Console.WriteLine($"Days until expiration: {daysUntilExpiration}");
int discountPercentage = 0;

if (daysUntilExpiration <= 10)
{
  if (daysUntilExpiration > 5)
  {
    Console.WriteLine("Your subscription will expire soon. Renew now!");
  }
  else if (daysUntilExpiration > 1)
  {
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
  }
  else if (daysUntilExpiration == 1)
  {
    Console.WriteLine("Your subscription expires within a day.");
    discountPercentage = 20;
  }
  else
  {
    Console.WriteLine("Your subscription has expired.");
  }
}

if (discountPercentage > 0)
{
  Console.WriteLine($"Renew now and save {discountPercentage}%!");
}