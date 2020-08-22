using System;
using System.ComponentModel.DataAnnotations;

namespace MovieRegistration.Models
{
    internal class ValidDateAttribute : ValidationAttribute
    {
        public DateTime Year { get; set; }
        public DateTime StartDate = new DateTime(1880, 1, 1);
        public DateTime EndDate = new DateTime(2020,12,31);

        protected override ValidationResult IsValid(object movie, ValidationContext validationContext)
        {
            movie = new Movie();



            if (Year > StartDate || Year < EndDate)
            {
                return new ValidationResult("Please enter a date after 1880 or before 2020");
            }
            else
            {
                return ValidationResult.Success;
            }
            
        }
    }
}