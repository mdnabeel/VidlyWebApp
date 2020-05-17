using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VidlyWebApp.Models;

namespace VidlyWebApp.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        //  public Movies Movie { get; set; }

      public int? Id { get; set; }

    [Required]
    [StringLength(255)]
    [Display(Name = "Movie Name")]
    public string MovieName { get; set; }



    [Required]
    [Display(Name = "Genre")]
    public byte? GenreId { get; set; }

    [Required]
    [Display(Name = "Release Date")]
    public DateTime? ReleasedDate { get; set; }


    [Required]
    [Display(Name = "Number in Stock")]
    [Range(1, 20)]
    public byte? NumberInStock { get; set; }
    public string Title
    {
        get
        {
            // if (Movie != null && Movie.Id != 0)
            //return "Edit Movie";
            //return "New Movie";

            return Id != 0 ? "Edit Movie" : "New Movie";
        }
    }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movies movie)
        {
            Id = movie.Id;
            MovieName = movie.MovieName;
            ReleasedDate = movie.ReleasedDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
}


}