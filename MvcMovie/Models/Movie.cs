﻿using System;
using System.Data.Entity;


namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        // to create the movies db automatically
        //public MovieDBContext() : base("MovieDBContext") { }
        public DbSet<Movie> Movies { get; set; }
    }
}