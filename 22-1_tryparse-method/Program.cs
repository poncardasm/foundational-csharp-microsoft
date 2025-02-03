// string value = "102";
// int result = 0;

// if (int.TryParse(value, out result))
// {
//   Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//   Console.WriteLine($"Unable to report the measurement.");
// }

// Console.WriteLine($"Measurement with offset: {50 + result}");

/*
  Modify the string variable to a value that can't be parsed
*/

string value = "bad";
int result = 0;

if (int.TryParse(value, out result))
{
  Console.WriteLine($"Measuremtn: {result}");
}
else
{
  Console.WriteLine($"Unable to report the measurement.");
}

if (result > 0)
  Console.WriteLine($"Measurement with offset: {50 + result}");