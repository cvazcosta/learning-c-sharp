string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderIDs = orderStream.Split(",");
Array.Sort(orderIDs);

for (int i = 0; i < orderIDs.Length; i++)
{
  char[] orderID = orderIDs[i].ToCharArray();
  if (orderID.Length != 4)
  {
    orderIDs[i] += "\t- Error";
  }
}

foreach (var orderID in orderIDs)
{
  Console.WriteLine(orderID);
}