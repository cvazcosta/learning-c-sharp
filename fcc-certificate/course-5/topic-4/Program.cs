string? userInput;
string formattedInput = "";
bool validInput = false;

Console.WriteLine("- Administrator");
Console.WriteLine("- Manager");
Console.WriteLine("- User");

do
{
  Console.Write("Inform your role: ");
  userInput = Console.ReadLine();

  if (userInput != null)
  {
    switch (userInput.Trim().ToLower())
    {
      case "administrator":
      case "manager":
      case "user":
        validInput = true;
        formattedInput = userInput.Trim().ToLower();
        continue;
      default:
        Console.WriteLine($"Invalid input: the role {userInput} does not exist.");
        continue;
    }    
  }
  else
  {
    Console.WriteLine("Invalid input: no text was typed.");
  }

} while (validInput == false);

Console.WriteLine($"Valid input: you are a {formattedInput}");
