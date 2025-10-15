string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"];

int periodLocation;
string myString;

for (int i = 0; i < myStrings.Length; i++)
{
  myString = myStrings[i];
  do
  {
    periodLocation = myString.IndexOf('.');

    if (periodLocation != -1)
    {
      Console.WriteLine(myString.Remove(periodLocation));
      myString = myString.Substring(periodLocation + 1).TrimStart();
      continue;
    }

    Console.WriteLine(myString);
      
  } while (periodLocation != -1);
}