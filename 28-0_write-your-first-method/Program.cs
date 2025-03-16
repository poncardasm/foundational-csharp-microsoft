int[] a = { 1, 2, 3, 4, 5 };

Console.WriteLine($"Contents of Array: ");
printArray();

void printArray()
{
  foreach (int x in a)
  {
    Console.WriteLine($"{x}");
  }
  Console.WriteLine($"");
}

Console.WriteLine($"Before calling a method");
SayHello();
Console.WriteLine($"After calling a method");

void SayHello()
{
  Console.WriteLine($"Hello world!");
}