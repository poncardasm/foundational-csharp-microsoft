﻿int saleAmount = 1001;
int discount = saleAmount > 100 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

// v2
Console.WriteLine($"Discount: {(saleAmount > 100 ? 100 : 50)}");

