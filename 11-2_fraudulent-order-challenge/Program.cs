/*
Code challenge - Report the Order IDs that need further investigation

Your team has found a pattern. Orders that start with the letter "B" encounter fraud at a rate 25 times greater than the normal rate. You write new code that outputs the Order ID of new orders where the Order ID starts with the letter "B". This will be used by the fraud team to investigate further.
*/

string[] OrderIDs = [ "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" ];

Console.WriteLine("Order IDs: ");
foreach (string IDs in OrderIDs)
{
  Console.WriteLine(IDs);

  
}

Console.WriteLine("\nPotential fraudulent Order ID:");
foreach (string IDs in OrderIDs)
{
  if(IDs.StartsWith('B'))
  {
    Console.WriteLine($"{IDs}");
  }
}








