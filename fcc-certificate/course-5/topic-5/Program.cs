// string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"];

// periodLocation será usada p/ armazenar a posição do ponto em uma string
// int periodLocation = 0;

// foreach (string myString in myStrings)
// {

// }

string someSentence = "I like pizza. I like roast chicken. I like salad";

// Quando periodLocation != -1
int periodLocation = someSentence.IndexOf('.');
Console.WriteLine(someSentence.Remove(periodLocation));
someSentence = someSentence.Substring(periodLocation + 1).TrimStart();

periodLocation = someSentence.IndexOf('.');
Console.WriteLine(someSentence.Remove(periodLocation));
someSentence = someSentence.Substring(periodLocation + 1).TrimStart();

// Quando periodLocation == -1
Console.WriteLine(someSentence);