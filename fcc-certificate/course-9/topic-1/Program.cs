using System;

int[] times = { 800, 1200, 1600, 2000 };
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");

/* Format and display medicine times */
FormatMedicineTimes(times);

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
  Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
{
  diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

  /* Adjust the times by adding the difference, keeping the value within 24 hours */
  AdjustTime(times);
}
else
{
  diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

  /* Adjust the times by adding the difference, keeping the value within 24 hours */
  AdjustTime(times);
}

Console.WriteLine("New Medicine Schedule:");

/* Format and display medicine times */
FormatMedicineTimes(times);

//============Functions==============

// Format and display medicine times
void FormatMedicineTimes(int[] times)
{
  foreach (int val in times)
  {
    string time = val.ToString();
    int len = time.Length;

    if (len >= 3)
    {
      time = time.Insert(len - 2, ":");
    }
    else if (len == 2)
    {
      time = time.Insert(0, "0:");
    }
    else
    {
      time = time.Insert(0, "0:0");
    }

    Console.Write($"{time} ");
  }

  Console.WriteLine();
}

// Adjust the new time
void AdjustTime(int[] times)
{
  for (int i = 0; i < times.Length; i++)
  {
    times[i] = (times[i] + diff) % 2400;
  }
}