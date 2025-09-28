int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {discount}");

// Forma alternativa, mas menos legível que a de cima
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");