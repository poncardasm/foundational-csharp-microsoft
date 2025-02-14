/*
 * Composite formatting
 */
Console.WriteLine($"\n-- Composite formatting --\n");

string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

/*
 * String interpolation
 */
Console.WriteLine($"\n-- String interpolation --\n");

Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");


/*
 * Formatting Currency
 */
Console.WriteLine($"\n-- Formatting Currency --\n");

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

/*
 * Formatting Numbers
 */
Console.WriteLine($"\n-- Formatting Numbers --\n");

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");

/*
 * Formatting percentages
 */
Console.WriteLine($"\n-- Formatting percentages --\n");

decimal tax = 0.36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

/*
 * Combining formatting approaches
 */
Console.WriteLine($"\n-- Combining formatting approaches --\n");

decimal price2 = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price2 - salePrice), price2);

Console.WriteLine(yourDiscount);

/*
 * with this string interpolation approach
 */
Console.WriteLine($"\n-- with this string interpolation approach --\n");

decimal price3 = 67.55m;
decimal salePrice2 = 59.99m;

yourDiscount += $"A discount of {((price3 - salePrice2) / price3):P2}!"; //inserted
Console.WriteLine(yourDiscount);