Console.WriteLine("\n--- Reverse ---\n");
string value = "abc123";
char[] valueArray = value.ToCharArray();

Array.Reverse(valueArray);

string reversedValue = new string(valueArray);
Console.WriteLine(reversedValue);

Console.WriteLine("\n--- Join ---\n");
string value2 = "abc123";
char[] valueArray2 = value2.ToCharArray();
Array.Reverse(valueArray2);

string reversedValue2 = string.Join(",", valueArray2);
Console.WriteLine(reversedValue2);

Console.WriteLine("\n--- Split ---\n");
string[] items = reversedValue2.Split(',');
foreach (string item in items)
{
  Console.WriteLine(item);
}