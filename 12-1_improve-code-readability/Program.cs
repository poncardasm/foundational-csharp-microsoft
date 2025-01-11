string str = "The quick brown fox jumps over the lazy dog.";
// Convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the char
Array.Reverse(charMessage);
int x = 0;
// Count the o's
foreach (char i in charMessage)
{
  if (i == 'o')
  {
    x++;
  }
}
// Convert back to a string
string new_message = new string(charMessage);
// Print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");