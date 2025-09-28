# Exercício - Atualizar a saída formatada

O aplicativo Student Grading é usado para calcular e relatar as notas dos alunos com base em avaliações que valem nota e em tarefas de crédito extra. Sua meta neste desafio é atualizar o código que gera um relatório de pontuações de acordo com os requisitos atualizados do professor.

## Especificação

Neste primeiro exercício de desafio, você precisa instanciar as variáveis necessárias para o relatório de pontuações atualizado e atualizar a instrução Console.WriteLine() que grava as notas dos alunos no console.

O aplicativo atualizado deve fazer o seguinte:

- usar as matrizes e os valores de matriz existentes para todos os cálculos de nota dos alunos.
- usar a estrutura aninhada fornecida pelas instruções foreach e if existentes.
- declarar e inicializar quaisquer outras variáveis de inteiro necessárias para calcular as somas.
- declarar e inicializar quaisquer outras variáveis decimais necessárias para cálculos e/ou valores de relatório de pontuações.

O formato do relatório de pontuações atualizado é o seguinte:

```Plain Text
Student         Exam Score      Overall Grade   Extra Credit

Sophia          0               95.8    A       0 (0 pts)
Andrew          0               91.2    A-      0 (0 pts)
Emma            0               90.4    A-      0 (0 pts)
Logan           0               93      A       0 (0 pts)
```

## Verificar seu trabalho

Para validar que o código atende aos requisitos especificados para este exercício, siga estas etapas:

Use o Visual Studio Code para compilar e executar seu aplicativo.

Verifique se o aplicativo cria a seguinte saída:

```Plain Text
Student         Exam Score      Overall Grade   Extra Credit

Sophia          0               95.8    A       0 (0 pts)
Andrew          0               91.2    A-      0 (0 pts)
Emma            0               90.4    A-      0 (0 pts)
Logan           0               93      A       0 (0 pts)
```

O resultado correto será:

```Plain Text
Student         Exam Score      Overall Grade   Extra Credit

Sophia          92.2            95.88   A       92 (3.68 pts)
Andrew          89.6            91.38   A-      89 (1.78 pts)
Emma            85.6            90.94   A-      89 (5.34 pts)
Logan           91.2            93.12   A       96 (1.92 pts)
```
