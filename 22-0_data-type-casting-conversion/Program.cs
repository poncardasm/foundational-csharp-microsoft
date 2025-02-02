// int first = 2;
// string second = "4";
// string result = first + second;

// Console.WriteLine(result);

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine(myDecimal);

/****
  Perform a cast
***/

// decimal myDecimal = 3.14m;
// Console.WriteLine($"Decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

/***
  Determine if your conversion is a "widening conversion" or a "narrowing conversion"
***/

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");

/***
  Use ToString() to convert a number to a string
***/

int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);