namespace LINQ.ProductionCode.Cinemas;

public class Cinema
{
    public List<Movie> Movies { get; private set; }
    
    public Cinema(List<Movie> movies)
    {
        Movies = movies;
    }

    // 01
    public List<Movie> GetMoviesWithRatingGreaterThan(double rating)
    {
        var result = new List<Movie>();
        foreach (var movie in Movies)
        {
            if (movie.Rating > rating)
            {
                result.Add(movie);
            }
        }

        return result;
    }

    // 02
    public List<string> GetTitleOfMoviesOlderThan(int year)
    {
        var result = new List<string>();
        foreach (var movie in Movies)
        {
            if (movie.Year < year)
            {
                result.Add(movie.Title);
            }
        }

        return result;
    }

    // 03
    public Movie GetMovieWithHighestRating()
    {
        var highestRatedMovie = Movies[0];
        foreach (var movie in Movies)
        {
            if (movie.Rating > highestRatedMovie.Rating)
            {
                highestRatedMovie = movie;
            }
        }

        return highestRatedMovie;
    }

    // 04
    public string GetLowestRatedMovieTitleFromYear(int year)
    {
        var lowestRatedMovie = Movies[0];
        foreach (var movie in Movies)
        {
            if (movie.Year == year)
            {
                if (movie.Rating < lowestRatedMovie.Rating)
                {
                    lowestRatedMovie = movie;
                }
            }
        }

        return lowestRatedMovie.Title;
    }

    // 05
    public List<Movie> GetMoviesAboveAverageRating()
    {
        double totalRating = 0;
        foreach (var movie in Movies)
        {
            totalRating += movie.Rating;
        }
        var averageRating = totalRating / Movies.Count;

        var result = new List<Movie>();
        foreach (var movie in Movies)
        {
            if (movie.Rating > averageRating)
            {
                result.Add(movie);
            }
        }

        return result;
    }

    // 06
    // public List<string> GetTopMovieTitlesByRating(int numberOfTitles)
    // {
    //     var sortedMovies = new List<Movie>(Movies);
    //     sortedMovies.Sort((movie1, movie2) => movie2.Rating.CompareTo(movie1.Rating));
    // 
    //     var topMovieTitles = new List<string>();
    //     for (int i = 0; i < numberOfTitles; i++)
    //     {
    //         topMovieTitles.Add(sortedMovies[i].Title);
    //     }
    // 
    //     return topMovieTitles;
    // }
}
