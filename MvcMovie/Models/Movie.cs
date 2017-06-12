using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        // combining attributes on one line
        // [Display(Name = "Release Date"),DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        // combining attributes on one line
        // [Range(1, 100),DataType(DataType.Currency)]
        [Range(1,100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(5)]
        public string Rating { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        // to create the movies db automatically
        public MovieDBContext() : base("MovieDBContext") { }
        public DbSet<Movie> Movies { get; set; }
    }
}