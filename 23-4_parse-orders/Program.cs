string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderLists = orderStream.Split(',');
Array.Sort(orderLists);

foreach (var orderList in orderLists)
{
  if (orderList.Length != 4)
  {
    Console.WriteLine($"{orderList} \t - Error");
  }
  else
  {
    Console.WriteLine(orderList);
  }
}