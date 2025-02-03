string[] values = { "12.3", "45", "ABC", "11", "DEF" };
float total = 0;

foreach (string value in values)
{
  if (float.TryParse(value, out float result))
  {
    total += result;
  }
}

Console.WriteLine($"Total: {total}");