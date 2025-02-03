string[] values = { "12.3", "45", "ABC", "11", "DEF" };
float result = 0;
float total = 0;

foreach (string value in values)
{
  if (float.TryParse(value, out result))
  {
    total += result;
  }

  Console.WriteLine($"Total: {total}");
}