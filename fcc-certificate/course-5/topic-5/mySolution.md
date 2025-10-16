# Descrição da solução

Foram declaradas 3 variáveis:

- 1 matriz de strings `myStrings` unidimensional com 2 elementos;
- 1 int `periodLocation`;
- 1 string `myString`;

- É iniciado um loop externo `for` com *inicializador* `i = 0`, *condição* `i < myStrings.Length` e *iterador* `i++` em que:
  - `myString` recebe o valor de `myStrings[i]`.
  - É iniciado um loop interno `do-while` que:
    - `periodLocation` é definido como o valor do índice do primeiro ponto encontrado usando `.IndexOf('.')`;
    - Se `periodLocation != -1` então:
      - Imprimo `myString.Remove(periodLocation)` que significa imprimir apenas os caracteres antes da posição do primeiro ponto final.
      - Atualizo o valor de `myString` com os método `Substring(periodLocation + 1).TrimStart()` que significa pegar apenas os caracteres a partir do índice imediatamente seguinte ao do primeiro ponto encontrado e remover o espaço vazio do início.
      - Pulo para a verificação da condição do `while`
    - Condição de saída do loop interno `periodLocation = -1` que significa que não há mais pontos finais.
  - Imprime `myString` nos casos em que não houver ponto final encontrado
  