// Aprendendo sobre os valores máximos e mínimos que variáveis integrais podem armazenar

Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long : {long.MinValue} to {long.MaxValue}");

Console.WriteLine();
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine();
Console.WriteLine("Floating point types:");
Console.WriteLine($"float : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal : {decimal.MinValue} to {decimal.MaxValue} (with ~28-29 digits of precision)");

// Definindo uma variável do tipo reference

int[] data;

// The previous code defines a variable that can hold a value of type int array.

// At this point, data is merely a variable that could hold a reference, or rather, a memory address of a value in the heap. Because it's not pointing to a memory address, it's called a null reference.

data = new int[3];

// Agora foi criada uma instância de um array de int chamada de data. data armazena o endereço de memória de um array de int com espaço para até 3 elementos. Por padrão, os valores dos elementos int não inicializados são 0.

// Tudo isso poderia ser feito em uma linha de codigo como em:

int[] data_2 = new int[3];