string? userInput;
int number = 0;
bool isInt = false;
bool validNumber = false;

Console.WriteLine("Digite um número inteiro entre 5 e 10");

do
{
  userInput = Console.ReadLine();
  isInt = int.TryParse(userInput, out number);

  if (isInt)
  {
    if ((number >= 5) && (number <= 10))
    {
      validNumber = true;
    }
    else
    {
      Console.WriteLine("Entrada inválida. O número informado não está entre 5 e 10.");
    }
  }
  else
  {
    Console.WriteLine("Entrada inválida! Não foi informado um número inteiro.");
  }

} while (validNumber == false);

Console.WriteLine($"O número digitado, {number}, é válido.");