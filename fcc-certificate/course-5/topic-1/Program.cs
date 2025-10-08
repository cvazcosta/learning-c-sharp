// Let's write code that will keep generating random numbers between 1 and 10 until we generate the number 7. It could take just one iteration to get a 7, or it could take dozens of iterations.

Random number = new();
int currentNumber = number.Next(1, 10);

do
{
  currentNumber = number.Next(1, 11);

  if (currentNumber >= 8) continue;

  Console.WriteLine(currentNumber); 
} while (currentNumber != 7);

// Write a while statement that iterates only while a random number is greater than some value


// while (currentNumber >= 3)
// {
//   Console.WriteLine(currentNumber);
//   currentNumber = number.Next(1, 10);
// }
// Console.WriteLine($"Current number: {currentNumber}");