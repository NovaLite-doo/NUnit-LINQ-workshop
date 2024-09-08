namespace LINQ.ProductionCode.Cinemas;

public class Movie
{
    public string Title { get; private set; }
    public double Rating { get; private set; }
    public int Year { get; private set; }

    public Movie(string title, double rating, int year)
    {
        Title = title;
        Rating = rating;
        Year = year;
    }
}
