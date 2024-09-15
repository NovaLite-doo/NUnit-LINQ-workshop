// See https://aka.ms/new-console-template for more information

using LINQ.ProductionCode.Numbers;

Console.WriteLine("Even numbers");
Console.WriteLine(string.Join(", ", OneDigitNumbers.GetEvenNumbers()));
Console.WriteLine();

Console.WriteLine("Numbers greater than 5");
Console.WriteLine(string.Join(", ", OneDigitNumbers.GetGreaterThan(5)));
Console.WriteLine();

Console.WriteLine("Numbers with more than 4 characters");
Console.WriteLine(string.Join(", ", OneDigitNumbers.GetWithMoreCharactersThan(4)));
Console.WriteLine();

Console.WriteLine("String numbers length");
Console.WriteLine(string.Join(", ", OneDigitNumbers.GetStringNumbersLength()));
Console.WriteLine();

Console.WriteLine("Sum of numbers");
Console.WriteLine(OneDigitNumbers.GetSum());
Console.WriteLine();

Console.WriteLine("Sum of even numbers");
Console.WriteLine(OneDigitNumbers.GetSumOfEvenNumbers());
Console.WriteLine();

// Console.WriteLine("Average of numbers");
// Console.WriteLine(OneDigitNumbers.GetAverage());
// Console.WriteLine();

// Console.WriteLine("Max number");
// Console.WriteLine(OneDigitNumbers.GetMax());
// Console.WriteLine();

// Console.WriteLine("Ordered numbers");
// Console.WriteLine(string.Join(", ", OneDigitNumbers.GetOrderedNumbers()));
// Console.WriteLine();
