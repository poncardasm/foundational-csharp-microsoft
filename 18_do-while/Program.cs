Random randomNum = new Random();
int current = 0;

do
{
  current = randomNum.Next(1, 11);
  Console.WriteLine(current);
} while (current != 7);