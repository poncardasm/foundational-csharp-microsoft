/*
 * Exercise - Complete a challenge to extract, replace, and remove data from an input string
*/

namespace _25_0_modify_content_of_strings;
public class ExtractReplaceRemove
{
  public static void Run()
  {
    const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

    string quantity = "";
    string output = "";

    // Extract quantity (number between <span> and </span>)
    int spanStart = input.IndexOf("<span>") + 6;
    int spanEnd = input.IndexOf("</span>");
    quantity = input.Substring(spanStart, spanEnd - spanStart);

    // Create output by removing div tags and replacing &trade with &reg

    output = input.Replace("<div>", "")
                  .Replace("</div", "")
                  .Replace("&trade", "&reg");

    Console.WriteLine($"Quantity: {quantity}");
    Console.WriteLine($"Qutput: {output}");
  }
}