string value = "abc123";
char[] valueArray = value.ToCharArray();

Array.Reverse(valueArray);

string reversedValue = new string(valueArray);
Console.WriteLine(reversedValue);