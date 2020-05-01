using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyWebApp.Models;

namespace VidlyWebApp.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movies Movie { get; set; }
        public List<Customers> Customer { get; set; }
    }
}