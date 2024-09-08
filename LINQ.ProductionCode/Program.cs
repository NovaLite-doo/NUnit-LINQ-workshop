// See https://aka.ms/new-console-template for more information

using LINQ.ProductionCode;
using LINQ.ProductionCode.Cinemas;

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

Console.WriteLine("Ordered numbers");
Console.WriteLine(string.Join(", ", OneDigitNumbers.GetOrderedNumbers()));
Console.WriteLine();

Console.WriteLine("Descending ordered numbers");
Console.WriteLine(string.Join(", ", OneDigitNumbers.GetDescendingOrderedNumbers()));
Console.WriteLine();

Console.WriteLine("Sum of numbers");
Console.WriteLine(OneDigitNumbers.GetSum());
Console.WriteLine();

Console.WriteLine("Average of numbers");
Console.WriteLine(OneDigitNumbers.GetAverage());
Console.WriteLine();

Console.WriteLine("Max number");
Console.WriteLine(OneDigitNumbers.GetMax());
Console.WriteLine();

Console.WriteLine("Sum of even numbers");
Console.WriteLine(OneDigitNumbers.GetSumOfEvenNumbers());
Console.WriteLine();


// Console.WriteLine("***************** Movies *****************");
// var movies = new List<Movie> {
//     new Movie("The Shawshank Redemption", 9.3, 1994),
//     new Movie("The Godfather", 9.2, 1972),
//     new Movie("Inception", 8.8, 2010),
//     new Movie("The Dark Knight", 9.0, 2008),
//     new Movie("Parasite", 8.6, 2019),
//     new Movie("Interstellar", 8.6, 2014),
//     new Movie("The Grand Budapest Hotel", 8.1, 2014),
//     new Movie("Joker", 8.4, 2019),
//     new Movie("Mad Max: Fury Road", 8.1, 2015),
//     new Movie("The Social Network", 7.7, 2010)
// };
// 
// var cinema = new Cinema(movies);