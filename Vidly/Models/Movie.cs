﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        public Genre Genre { get; set; }

        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }
        [Display(Name = "Number in Stock")]
        [Range (1, 20)]
        [Required(ErrorMessage = "The Number in Stock field must be between 1 and 20")]
        public byte InStock { get; set; }

        // Availiable shows how many movies are available to rent
        public byte Available { get; set; }

        [Display(Name="Release Date")]
        public DateTime ReleaseDate { get; set; }
    }

    
}