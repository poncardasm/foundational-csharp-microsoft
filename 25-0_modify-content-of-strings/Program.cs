/*
 * Write code to find parenthesis pairs embedded in a string
 */
Console.WriteLine($"\n-- Write code to find parenthesis pairs embedded in a string --\n");

string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);

/*
 * Add code to retrieve the value between parenthesis
 */
Console.WriteLine($"\n-- Add code to retrieve the value between parenthesis --\n");

openingPosition += 1;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

/*
 * Modify the starting position of the sub string
 */
Console.WriteLine($"\n-- Modify the starting position of the sub string --\n");

string newMessage = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int newOpeningPosition = newMessage.IndexOf(openSpan);
int newClosingPosition = newMessage.IndexOf(closeSpan);

newOpeningPosition += openSpan.Length;

int newLength = newClosingPosition - newOpeningPosition;
Console.WriteLine(newMessage.Substring(newOpeningPosition, newLength));