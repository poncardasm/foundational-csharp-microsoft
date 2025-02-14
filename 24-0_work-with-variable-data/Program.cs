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