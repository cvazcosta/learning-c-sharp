# Métodos em C-Sharp

O objetivo do capítulo foi o de mostrar os dois tipos de métodos presentes na linguagem C# e as diferentes formas pelas quais eles podem ser declarados, segundo a sintaxe correta.

## Stateful Method - Métodos de Instância

O método `Next()` da *class* `Random` é conhecido como *stateful method*.

A *class* `Random` precisa ser **instanciada** (usando `new()` ou `new Random()`). Que significa criar um objeto que terá um estado interno próprio que será definido a cada execução do programa (neste caso, o *seed* e o progresso da sequência dos números aleatórios).

O método `.Next(1, 7)` é um método de instância, isto é, ele precisa de um objeto específico para sua execução (em nosso exemplo, o objeto é `dice`). E seu comportamento vai depender do estado interno deste objeto.

## Static (stateless) Method

Um método estático não precisa de instância. Ele pertence à *class* e não ao objeto.

Como exemplo, temos o método `Math.Max(5, 10)`. O resultado retornado pela função dependerá exclusivamente de seus parâmetros e não do estado interno do objeto, como no caso anterior.

## Overloaded Methods

Overloaded methods são métodos que podem ser executados de formas diferentes, com relação à quantidade de argumentos que podem ser fornecidos.

Como exemplo temos `Random.Next()` que pode ser chamada de três formas:

  1. Sem argumentos, retornando qualquer inteiro entre 0 e 2.147.483.647;
  2. Com 1 argumento, que é considerado como o limite superior (intervalo exclusivo);
  3. Com 2 argumentos, limite inferior (inclusivo) e limite superior (exclusivo).
