/*
 * Exercise - Use the Remove() and Replace() methods
*/

namespace _25_0_modify_content_of_strings;
public class RemoveReplaceMethod
{
  public static void Run()
  {
    // Remove characters in specific locations from a string
    string data = "12345John Smith          5000  3  ";
    string updatedData = data.Remove(5, 20);
    Console.WriteLine(updatedData);

    // Use the Replace() method
    string message = "This--is--ex-amp-le--da-ta";
    message = message.Replace("--", " ");
    message = message.Replace("-", "");
    Console.WriteLine(message);
  }
}

