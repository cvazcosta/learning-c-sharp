string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

openingPosition++;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

// Segundo exemplo
string message2 = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
// const string closeSpan = "</span>";
int firstAngleBracketPosition = message2.IndexOf('<');
int lastAngleBracketPosition = message2.LastIndexOf('>');
int openingPosition2 = message2.IndexOf("<span>");
int closingPosition2 = message2.IndexOf("</span>");

// Verificando qual o valor de índice retornado quando uma string é passada para o IndexOf()
Console.WriteLine($"first angle bracket: {firstAngleBracketPosition}");
Console.WriteLine($"last angle bracket: {lastAngleBracketPosition}");
Console.WriteLine($"openingPosition2: {openingPosition2}");
Console.WriteLine($"closingPosition2: {closingPosition2}");

openingPosition2 += openSpan.Length;

int length2 = closingPosition2 - openingPosition2;
Console.WriteLine(message2.Substring(openingPosition2, length2));

// Terceira unidade
string message3 = "hello there!";

int first_h = message3.IndexOf('h');
int last_h = message3.LastIndexOf('h');

Console.WriteLine($"For the message: '{message3}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}");

// Exercício
string message4 = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition4 = message.LastIndexOf('(');

openingPosition4 += 1;
int closingPosition4 = message.LastIndexOf(')');
int length4 = closingPosition4 - openingPosition4;
Console.WriteLine(message4.Substring(openingPosition4, length4));