/*
Exercise - Implement the foreach statement

Suppose you work for a manufacturing company. The company needs you to complete an inventory of your warehouse to determine the number of products that are ready to ship. In addition to the total number of finished products, you need to report the number of finished products stored in each individual bin in your warehouse, along with a running total. This running total will be used to create an audit trail so you can double-check your work and identify "shrinkage".
*/

string[] names = [ "Rowena", "Robin", "Bao" ];
foreach (string name in names)
{
  Console.WriteLine(name);
}