using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Management.System.Models;

namespace Cinema.Management.System.ViewModels
{
    public class actorMovieViewModel
    {
        public Movie movie {get; set;}
        public List<Actor> actors { get; set; }

        public actorMovieViewModel(Movie movie,List<Actor> actors)
        {
            this.movie=movie;
            this.actors=actors;
        }
    }
}