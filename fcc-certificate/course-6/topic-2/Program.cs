// Tentando somar um int com uma string salvando o resultado em um int. Aqui é levantado um erro de runtime exception, pois o compilador evita fazer a conversão implícita da string em int visto que há a possibilidade que o valor de second seja algo que não possa ser convertido em int

// int first = 2;
// string second = "4";
// int result = first + second;
// Console.WriteLine(result);

// Fazendo widening conversion, isto é, convertendo de um data type que é capaz de armazenar menos informação para um que é capaz de armazenar mais informação, o que possibilita confiar na conversão implícita de int para decimal

// decimal myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// Fazendo um type cast do tipo narrowing conversion

decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");
Console.WriteLine(myDecimal.GetType());

// Outro exemplo de narrowing conversion

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"decimal: {myDecimal}");
// Console.WriteLine($"float  : {myFloat}");

// Usando ToString()

// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

// Convertendo string em int por meio de Parse()
// Aqui vemos que há um potencial para geração de runtime errors no caso de first ou second terem valores que não podem ser convertidos em int. Por isso tryParse() é uma solução melhor que o Parse(), pois ele permite tratar essas situações

// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

// Convertendo string em int usando a Class Convert
// Sua recomendação é para uso em conversão de valores fracionários em inteiros, pois é feito o arredondamento da forma esperada

// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) + Convert.ToInt32(value2);
// Console.WriteLine(result);

// Vendo como casting e converting tratam uma conversão de decimal em int
// int value = (int)1.5m;
// Console.WriteLine(value); // resultado é truncado p/ 1

// int value2 = Convert.ToInt32(1.5m); // resultado é arredondado p/ 2
// Console.WriteLine(value2);

// Testando TryParse()

string value = "102";
int result = 0;

if (int.TryParse(value, out result))
{
  Console.WriteLine($"Measurement: {result}");
}
else
{
  Console.WriteLine("Unable to report the measurement.");
}