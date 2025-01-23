/*
  Add looping logic to your code using the do-while and while statements in C#
  https://learn.microsoft.com/en-us/training/modules/csharp-do-while/
*/

Random randomNum = new Random();
int current = 0;

do
{
  current = randomNum.Next(1, 11);
  Console.WriteLine(current);
} while (current != 7);