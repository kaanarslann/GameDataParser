﻿namespace GameDataParser
{
    public class Game
    {
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public double Rating { get; set; }

        public Game(string title, int releaseYear, double rating)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Rating = rating;
        }
    }
}
