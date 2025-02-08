string pangram = "The quick brown fox jumps over the lazy dog";
string[] pangramSplits = pangram.Split(" ");

foreach (var pangramSplit in pangramSplits)
{
  char[] pangramChars = pangramSplit.ToArray();
  Array.Reverse(pangramChars);

  string pangramReverse = new(pangramChars);

  Console.Write(pangramReverse + " ");
}

