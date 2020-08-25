using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MovieRegistration.Models
{
    public enum Genre
    { 
        Scifi,
        Horror,
        Action,
        Drama,
        Romance
    }
    public class Movie
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please Enter a valid Name")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Must be between 2 and 50 characters!")]
        public string Title { get; set; }
        [Required]
        public Genre Genre { get; set; }
        [Required]
        [Range(typeof(DateTime), "1/1/1880", "12/31/2020", ErrorMessage = "Date is out of Range")]
        public DateTime Year { get; set; }
        [Required(ErrorMessage = "Please Enter a valid Actor")]
        public string Actors { get; set; }
        [Required(ErrorMessage = "Please Enter a valid Director")]
        public string Directors { get; set; }

        public Movie()
        { 
        
        }
        public Movie(int ID, string title, Genre genre, DateTime year, string actors, string directors)
        {
            this.ID = ID;
            this.Title = title;
            this.Genre = genre;
            this.Year = year;
            this.Actors = actors;
            this.Directors = directors;
        }
    }

}
