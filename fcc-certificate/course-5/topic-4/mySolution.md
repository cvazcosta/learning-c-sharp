# Descrição da solução

- 1 nullable string `userInput`
- 1 string `formattedInput`
- 1 bool `validInput = false`

- 3 prompts informando os roles possíveis.

- É feito um loop `do-while` que:
  - Solicita que o usuário digite seu role
  - Atribui a entrada do usuário à `userInput`
  - Se `userInput != null`
    - É feito um switch usando `userInput.Trim().ToLower`
      - Os cases são *administrator*, *manager* e *user*. Se cair neles, `validInput = true` e `formattedInput` recebe a entrada do usuário limpa de espaços e em minúsculo
      - Default é um log informando que o role digitado não existe.
  - Senão:
    - Log para o usuário informando que ele não informou nenhum texto
- A condição de saída é `validInput = true`

- No final, é impresso um log ao usuário informando qual seu role.
