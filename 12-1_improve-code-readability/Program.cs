/*
  This code performs the following steps:
  1. Converts the given message into a character array.
  2. Reverses the character array and counts the occurrences of the letter 'o'.
  3. Converts the reversed character array back into a string.
  4. Prints the reversed message and the count of 'o' characters.
*/


string str = "The quick brown fox jumps over the lazy dog.";
char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);
int x = 0;
foreach (char i in charMessage)
{
  if (i == 'o')
  {
    x++;
  }
}
string new_message = new string(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");