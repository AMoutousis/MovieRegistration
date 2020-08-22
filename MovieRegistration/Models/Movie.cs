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
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Must be between 2 and 50 characters!")]
        public string Title { get; set; }
        [Required]
        public Genre Genre { get; set; }
        [Required]
        [ValidDate]
        public DateTime Year { get; set; }
        [Required]
        public string Actors { get; set; }
        [Required]
        public string Directors { get; set; }
    }
}
