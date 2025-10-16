# Solução proposta

```C#
string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();
```

## Descrição da solução

Foram declaradas 4 variáveis:

- 1 nullable string `readResult`;
- 1 string `valueEntered`;
- 1 int `numValue`;
- 1 bool `validNumber`;

- É realizado o prompt solicitando a entrada de um inteiro de 5 a 10 ao usuário;

- É feito um loop `do-while` que:
  - Atribui a entrada do usuário à variável `readResult`
  - Se `readResult` for != de null:
    - `valueEntered` = `readResult`

  - É feita uma verificação se a entrada do usuário pode ser convertida em um value do tipo int. Caso seja, `validNumber` = true e `numValue` = `valueEntered` já convertida em int.

  - Se `validNumber` = true:
    - É feita uma validação em `if` para ver se `validNumber` está entre 5 e 10.
    - Se não estiver, `validNumber` = false e é dado um output para o usuário informar um valor dentro do intervalo especificado.
  - Senão:
    - É dado um output para o usuário solicitando um número válido.

  - A condição de saída do loop é `validNumber` = true

No final o usuário recebe um log informando o valor digitado e que ele foi aceito.
