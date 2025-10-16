# Solução proposta

```C#
string? readResult;
string roleName = "";
bool validEntry = false;

do
{                
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();
```

## Descrição da solução

Foram declaradas 3 variáveis:

- 1 nullable string `readResult`;
- 1 string `roleName = ""`;
- 1 bool `validEntry = false`;

- É feito um loop `do-while` que:
  - Realiza o prompt ao usuário solicitando que digite seu cargo dentre 3 opções possíveis
  - Atribui a entrada do usuário à variável `readResult`
  - Se `readResult != null`:
    - `roleName` recebe o valor de `readResult` sem espaços vazios por meio do método `Trim()`
  - Se a string `roleName`, toda em minúscula pelo uso de `ToLower()` for igual aos três cargos possíveis, `validEntry = true`
  - Senão é dado um log ao usuário informando que a entrada foi inválida
  - A condição de saída do loop é `validEntry = true`

- No final o usuário recebe um log informando o valor digitado e que ele foi aceito.
