using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Management.System.Models;

namespace Cinema.Management.System.ViewModels
{
    public class MovieCreateViewModel
    {
        public Movie movie { get; set; }
        public string category { get; set; }
        public Director director { get; set; }

        public MovieCreateViewModel(Movie movie, string category, Director director)
        {
            this.movie = movie;
            this.category = category;
            this.director = director;
        }

    }
}