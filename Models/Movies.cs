using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyWebApp.Models
{
    public class Movies
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name ="Movie Name")]
        public string MovieName { get; set; }
        
        public Genre Genre { get; set; }

        [Required]
        [Display(Name ="Genre")]
        public byte GenreId { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleasedDate { get; set; }
        public DateTime DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        public byte NumberInStock { get; set; }

    }
}