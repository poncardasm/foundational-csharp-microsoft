string[] pallets = ["B14", "A11", "B12", "A13"];
Console.WriteLine("Sorted...");

Array.Sort(pallets);

foreach (var pallet in pallets)
{
  Console.WriteLine($"-- {pallet}");
}

/*
 * Reverse the order of the pallets
 */

Console.WriteLine("\nReversed...");
Array.Reverse(pallets);

foreach (var pallet in pallets)
{
  Console.WriteLine($"-- {pallet}");
}
