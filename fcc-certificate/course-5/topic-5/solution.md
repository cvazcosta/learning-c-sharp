# Solução Proposta

```C#
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
  myString = myStrings[i];
  periodLocation = myString.IndexOf(".");

  string mySentence;

  // extract sentences from each string and display them one at a time
  while (periodLocation != -1)
  {

    // first sentence is the string value to the left of the period location
    mySentence = myString.Remove(periodLocation);
    // 1 -> I like pizza
    // 2 -> I like roast chicken

    // the remainder of myString is the string value to the right of the location
    myString = myString.Substring(periodLocation + 1);

    // remove any leading white-space from myString
    myString = myString.TrimStart();
    // 1 -> I like roast chicken. I like salad
    // 2 -> I like salad

    // update the comma location and increment the counter
    periodLocation = myString.IndexOf(".");
    // 1 -> != -1 is true
    // 2 -> != -1 is false

    Console.WriteLine(mySentence);
    // 1 -> I like pizza
    // 2 -> I like roast chicken
  }

  mySentence = myString.Trim();
  // -> I like salad
  Console.WriteLine(mySentence);
  // -> I like salad
}
```

## Descrição da solução

Foram declaradas 4 variáveis:

- 1 array de strings `myStrings` com 2 strings;
- 1 int `stringsCount` que conta o número de elementos no array com `myStrings.Length`
- 1 string `myString = ""`
- 1 int `periodLocation`

- É feito um loop externo `for` partindo de 0 e indo até antes do valor de `stringsCount`, que é 2 nesse Caso
  - `myString` recebe o valor de `myStrings[i]`
  - `periodLocation` recebe o valor do índice da posição do ponto por meio de `myString.IndexOf('.')
  - É declarada uma variável local `mySentence`
  - É feito um loop interno `while` enquanto periodLocation != -1`, que significa que um ponto final foi encontrado
    - `mySentence` recebe `myString.Remove(periodLocation)` que significa receber apenas a parte da string até antes do ponto. Os caracteres posicionados do índice até o final são *removidos*.
    - `myString` tem seu valor modificado, pegando apenas os caracteres após `periodLocation` usando `myString.Substring(periodLocation + 1)`
    - `myString` tem qualquer espaço no seu início removido com `.TrimStart()`
    - `periodLocation` tem seu valor atualizado usando `.IndexOf('.') novamente
    - `mySentence` é impressa na tela
  - O loop é encerrado quando `periodLocation = -1`

- Abaixo do loop há um comando para imprimir a frase aparando espaços no começo e no fim, quando `periodLocation = -1`
