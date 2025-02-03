string[] values = { "12.3", "45", "ABC", "11", "DEF" };
float total = 0;
string message = "";

foreach (string value in values)
{
  if (float.TryParse(value, out float result))
  {
    total += result;
  }
  else
  {
    message += value;
  }

}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");

/*
// Example solution:

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number; // stores the TryParse "out" value
    if (decimal.TryParse(value, out number))
    {
        total += number;
    } else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");
*/