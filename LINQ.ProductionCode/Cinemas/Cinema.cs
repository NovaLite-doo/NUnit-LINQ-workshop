namespace LINQ.ProductionCode.Cinemas;

public class Cinema
{
    public List<Movie> Movies { get; private set; }
    
    public Cinema(List<Movie> movies)
    {
        Movies = movies;
    }

    public IEnumerable<Movie> GetMoviesWithRatingGreaterThan(double rating)
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

    public IEnumerable<string> GetTitleOfMoviesOlderThan(int year)
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

    public Movie GetMovieWithHighestRating()
    {
        Movie highestRatedMovie = Movies[0];
        foreach (var movie in Movies)
        {
            if (movie.Rating > highestRatedMovie.Rating)
            {
                highestRatedMovie = movie;
            }
        }

        return highestRatedMovie;
    }

    public string GetLowestRatedMovieTitleFromYear(int year)
    {
        Movie lowestRatedMovie = Movies[0];
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

    public IEnumerable<Movie> GetMoviesAboveAverageRating()
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

    public List<string> GetTopMovieTitlesByRating(int numberOfTitles)
    {
        var sortedMovies = new List<Movie>(Movies);
        sortedMovies.Sort((movie1, movie2) => movie2.Rating.CompareTo(movie1.Rating));

        var topMovieTitles = new List<string>();
        for (int i = 0; i < numberOfTitles; i++)
        {
            topMovieTitles.Add(sortedMovies[i].Title);
        }

        return topMovieTitles;
    }

    public Dictionary<int, List<Movie>> GetMoviesGroupedByYear()
    {
        var result = new Dictionary<int, List<Movie>>();
        foreach (var movie in Movies)
        {
            if (!result.ContainsKey(movie.Year))
            {
                result.Add(movie.Year, new List<Movie>());
            }
            result[movie.Year].Add(movie);
        }

        return result;
    }
}
