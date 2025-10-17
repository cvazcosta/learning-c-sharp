# Starter Project - Code Review

- São declaradas 6 variáveis do tipo `string` para armazenar os valores dos atributos dos animais:

- São declaradas 3 variáveis que podem receber entrada de dados do usuário:
  - `maxPets`, que determina a quantidade de linhas/registros da matriz bidimensional `ourAnimals`, a qual armazenará todos os atributos para cada animal cadastrado;
  - `readResult` que é uma `string?` (nullable string) para armazenar a entrada do usuário;
  - `menuSelection` que é uma `string` que irá armazenar a conversão de `readResult` para minúsculas, se a entrada do usuário for `!= null`

- É declarada um array bidimensional de `string` chamado `ourAnimals` que terá [maxPets, 6] de dimensões.

- Inicia-se um loop `for` com os atributos (i = 0; i < maxPets; i++)
  - Há 4 ifs dos valores 0 a 3 com diferentes conjuntos de valores para as variáveis de armazenamento de atributos e um else que mantém todos os atributos inicializados de forma vazia.
  - Após o bloco `if-else`, todas as colunas da linha `i` são preenchidas com strings formatadas e concatenadas com o resultado das variáveis.

- Após o preenchimento de dados, o console é limpo e vem os prompts informando os números e opções respectivas, concluindo com uma chamada à uma entrada do usuário.

- A entrada é lida e armazenada em `readResult` e se não for nula, uma cópia toda em minúscula é salva em `menuSelection`.

- O código é finalizado com um log mostrando qual a opção digitada pelo usuário o clássico aperte Enter para continuar.
