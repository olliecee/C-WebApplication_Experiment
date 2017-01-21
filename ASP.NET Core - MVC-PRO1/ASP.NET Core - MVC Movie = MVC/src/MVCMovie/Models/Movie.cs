using System;
using System.ComponentModel.DataAnnotations;

namespace MVCMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        [Display(Name = "Current Price")]
        public decimal Price { get; set; }
        [Display(Name = "Popularity")]
        public string Rating { get; set; }
    }
}