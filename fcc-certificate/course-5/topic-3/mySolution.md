# Descrição da minha solução

Foram declaradas 4 variáveis:

- 1 nullable string `userInput`;
- 1 int `number`
- 1 bool `isInt = false`;
- 1 bool `validNumber = true`;

- É realizado o prompt solicitando a entrada de um inteiro de 5 a 10 ao usuário;

- É feito um loop `do-while` que:

  - Atribui a entrada do usuário à `userInput`
  - É feita uma verificação se a entrada do usuário pode ser convertida em um value do tipo int. Caso seja, `isInt = true` e `number` recebe a entrada do usuário convertida em int.

  - Se `isInt = true`:
    - É feita uma validação se o número está entre 5 e 10.
    - Se estiver, `validNumber = true`
    - Senão, é dado um log ao usuário pedindo um número entre 5 e 10;
  - Senão:
    - É dado um log ao usuário informando que a entrada não foi um número inteiro.
  - A condição de saída é `validNumber = true`;

- No final o usuário recebe um log informando o valor digitado e que ele foi aceito.
