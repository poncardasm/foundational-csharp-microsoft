// Create a variable inside of a code block
bool flag = true;
if (flag)
{
  int value = 10;
  Console.WriteLine($"Inside the code block: {value}");
}

// Attempt to access a variable outside the code block in which it's declared

bool flag2 = true;
if (flag2)
{
  int value2 = 10;
  Console.WriteLine($"Inside the code block: {value2}");
}
Console.WriteLine($"Inside the code block: {value2}");