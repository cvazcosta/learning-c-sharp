string? userInput;
bool validInput = false;

Console.WriteLine("Inform your role:");
Console.WriteLine("- Administrator");
Console.WriteLine("- Manager");
Console.WriteLine("- User");

userInput = Console.ReadLine();

if (userInput != null)
{
  // userInput.ToLower();
  Console.WriteLine(userInput.Trim().ToLower());
}

Console.WriteLine(userInput);

// while (validInput == false)
// {
//   userInput = Console.ReadLine();

// }

// Estou pensando em usar um switch dentro do while tendo como valor de comparação a entrada do usuário "limpa" pelo uso do Trim() e do ToLower()

// Se a entrada do usuário for validada com sucesso, saímos do loop e imprimimos a mensagem de sucesso

// Implementar em breve