using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.DTOs
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        // commented out Genre to decouple Dto from domain model
        //[Required]
        //public Genre Genre { get; set; }

        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }
        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        [Required(ErrorMessage = "The Number in Stock field must be between 1 and 20")]
        public byte InStock { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
    }
}