﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyWebApp.Models;

namespace VidlyWebApp.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movies Movie { get; set; }
        public string Title
        {
            get
            {
                if (Movie != null && Movie.Id != 0)
                    return "Edit Movie";


                return "New Movie";
            }
        }
    }
}