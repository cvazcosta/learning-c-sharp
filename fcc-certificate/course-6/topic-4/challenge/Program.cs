string pangram = "The quick brown fox jumps over the lazy dog";
string invertedWord;
char[] word;

string[] items = pangram.Split(' ');
foreach (var item in items)
{
  word = item.ToCharArray();
  Array.Reverse(word);
  invertedWord = string.Join("", word);
  Console.Write(invertedWord + " ");
}

Console.WriteLine();