using System;
using System.Collections.Generic;
using Movies;

namespace MoviesHelper
{
    public class MoviesClass
    {
        public static List<someMovie> GetAllMovies()
        {
            return new List<someMovie>()
            {
                new someMovie() { Title = "Ford v Ferarri", Rating = 8.1f, Year = 2019, Duration = 152 },
                new someMovie() { Title = "Bad Boys for Life", Rating = 6.7f, Year = 2020, Duration = 124 },
                new someMovie() { Title = "Bloodshot", Rating = 5.7f,Year = 2020, Duration = 109},
                new someMovie() {Title = "Léon: The Professional", Rating = 8.5f,Year = 1994, Duration = 110},
                new someMovie() {Title = "Shazam!", Rating = 7.1f,Year = 2019, Duration = 132},
                new someMovie() {Title = "Star Wars: Episode 3 - Revange of the Sith", Rating = 7.5f,Year = 2005,Duration = 140},
                new someMovie(){Title = "Johnny English Strikes Again",Rating = 6.2f, Year = 2018,Duration = 89},
                new someMovie(){Title = "The Naked Gun", Rating = 7.6f,Year = 1988, Duration = 85},
                new someMovie(){Title = "The Exorcist", Rating = 8.0f, Year = 1973,Duration = 122},
                new someMovie(){Title = "The Conjuring",Rating = 7.5f,Year = 2013, Duration = 112},
                new someMovie(){Title = "Dracula",Rating = 7.4f,Year = 1992,Duration = 128}
            };
        }
    }
}
