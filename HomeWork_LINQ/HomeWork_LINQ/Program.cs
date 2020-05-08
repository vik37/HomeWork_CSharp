using Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using MoviesHelper;

namespace HomeWork_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            List<someMovie> movies = MoviesClass.GetAllMovies();

            foreach (var movie in movies)
            {
                Console.WriteLine( $"{movie.Title} - {movie.Rating} | {movie.Year} ({movie.Duration})");
            }
            Console.WriteLine("************************************************************");

            // Find all movies that their titles starts with "L"

            Console.ForegroundColor = ConsoleColor.Red;
            var allMoviesStartWithL = movies.Where(movie => movie.Title.StartsWith("L"))
                                                  .ToList();
            foreach (var movie in allMoviesStartWithL)
            {
                Console.WriteLine(movie.Title);
            }

            Console.WriteLine("-------------------------------------------------------------");
            //Find the NUMBER of movies that have rating higher than 7.5

            Console.ForegroundColor = ConsoleColor.Green;
            var ratingMoviesHigher = movies.Where(movie => movie.Rating > 7.5f)
                                                 .Select(movie => movie.Title)
                                                 .ToList().Count();

            Console.WriteLine("Number of movies rating higher than 7.5 is: {0}", ratingMoviesHigher);
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////");

            //Find all movies TITLES with year of production before 2005

            Console.ForegroundColor = ConsoleColor.Yellow;
            var allMoviesTitlewithYears = movies.Where(movie => movie.Year < 2005)                                              
                                                      .Select(movie => new { movie.Title, movie.Year })
                                                      .ToList();

            allMoviesTitlewithYears.ForEach(movie => Console.WriteLine($"Movies before " +
                $"2005 from list: Title {movie.Title} - Year: {movie.Year}"));
            Console.WriteLine("-------------------------------------------------------------");

            //Find all movies TITLES and RATING that have rating higher then 8.0


            Console.ForegroundColor = ConsoleColor.Cyan;
            var allMoviesAndRatingHighThen = movies.Where(movie => movie.Rating > 8.0)
                                                         .Select(movie => new { movie.Title, movie.Rating })
                                                         .ToList();
            allMoviesAndRatingHighThen.ForEach(movie => Console.WriteLine($"Film - Title : {movie.Title} Rating: {movie.Rating}"));

            // Find first 5 movies that have duration time longer then 2 hour

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            var longerMovies = movies.Where(movie => movie.Duration > 120)
                                           .Take(5)
                                           .ToList();
            longerMovies.ForEach(movie => Console.WriteLine($"TITLE [{movie.Title}], RATING [{movie.Rating}], YEAR [{movie.Year}]," +
                $" DURATION [{movie.Duration}]"));
            Console.ResetColor();
            Console.WriteLine("=====================================");

            // Find last 3 movies TITLES and DURATION that have duration less then 2 hours

            var lastMoviesLessThenTwoHours = movies.Where(movie => movie.Duration < 120)
                                                   .Select(movie => new { movie.Title, movie.Duration })
                                                   .OrderBy(movie => movie.Duration)
                                                   .Take(3)
                                                   .ToList();
            lastMoviesLessThenTwoHours.ForEach(movie => Console.WriteLine($"{movie.Title} === {movie.Duration}"));
            Console.WriteLine("/=========|==============|============|===========\\\n");

            // Find all movies TITLES and RATING and order them by DURATION (DESC) - no condition needed

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Yellow;

            var allMoviesTittleRattingOrderByDur = movies.OrderByDescending(movie => movie.Duration)
                                                         .Select(movie => new { movie.Title, movie.Rating })
                                                         .ToList();
            allMoviesTittleRattingOrderByDur.ForEach(movie => Console.WriteLine($"TITLE - {movie.Title}, RATING - {movie.Rating}"));

            // Find all movies with TITLES that don't start with A and TITLES include more than 7 characters
            Console.ResetColor();
            var allMoviesTitlesDontStartWithAAndLessThenSeven = movies.Where(movie => movie.Title.Length <= 7)                                                                           
                                                                             .Where(movie => movie.Title.StartsWith("A"))
                                                                            .ToList();
            allMoviesTitlesDontStartWithAAndLessThenSeven.ForEach(movie => Console.WriteLine("Movies: {0} ", movie.Title));
            Console.WriteLine("....................................................................................................");
            Console.WriteLine("NEMA TAKOV FILM VO KLASATA {Find all movies with TITLES that don't start with A and TITLES........} ");

            // NEMA TAKOV FILM STAVENO DALI E DOBRO I TOCNO NAPISANO VAKA???


            // Find all movies RATINGS that have RATINGS higher than 7.2, DURATIONS less then 1hour
            // and 50min
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------------------------------------------------------------");
            var allMoviesRatingHigherDurationLessThen = movies.Where(movie => movie.Rating > 7.2 && movie.Duration < 110)
                                                                    .Select(movie => movie.Rating)
                                                                    .ToList();
            allMoviesRatingHigherDurationLessThen.ForEach(movie => Console.WriteLine("RATINGS higher than 7.2, " +
                "DURATIONS less then 1hour and 50min == {0}", movie));

            // Find all movies TITLES and RATINGS that have TITLES with less than 10 characters, DURATION
            // longer than 2 hours, RATING higher then 6.7 and order them by TITLE(ASC)

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("________________________________________________________");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            var allMoviesTitlesRatingsWithDurLongerTitleLess = movies.Where(movie => movie.Duration > 120)
                                                                     .Select(movie => new { movie.Title, movie.Rating })
                                                                     .Where(movie => movie.Title.Length < 10)
                                                                     .Select(movie => new { movie.Title, movie.Rating })
                                                                     .Where(movie => movie.Rating > 6.7)
                                                                     .Select(movie => new { movie.Title, movie.Rating })
                                                                     .OrderByDescending(movie => movie.Title)
                                                                     .ToList();
            allMoviesTitlesRatingsWithDurLongerTitleLess.ForEach(movie => Console.WriteLine($"Title: {movie.Title} - Rating: {movie.Rating}"));


            Console.ReadLine();
        }
    }
}
