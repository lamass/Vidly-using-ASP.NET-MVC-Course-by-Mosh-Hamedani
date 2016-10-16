using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        // default constructor for New movie
        public MovieFormViewModel()
        {
            // setting Id = 0 populates the hidden Id field in MovieForm
            Id = 0;
        }

        // constructor for Edit movie
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            InStock = movie.InStock;
            GenreId = movie.GenreId;
        }
        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
      

        public byte? GenreId { get; set; }

       
        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        [Required(ErrorMessage = "The Number in Stock field must be between 1 and 20")]
        public byte? InStock { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        public IEnumerable<Genre> Genres { get; set; }

        public string  Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }
    }
}