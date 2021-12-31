using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Management.System.Models;

namespace Cinema.Management.System.ViewModels
{
    public class MovieViewModel
    {
        public Movie movie { get; set; }
        public List<Actor> actors { get; set; }
        public List<Comment> comments { get; set; }

        public MovieViewModel(Movie movie, List<Actor> actors, List<Comment> comments)
        {
            this.movie = movie;
            this.actors = actors;
            this.comments = comments;
        }
    }
}