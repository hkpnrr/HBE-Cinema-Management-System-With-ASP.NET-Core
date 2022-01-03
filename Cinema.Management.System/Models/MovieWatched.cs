using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Management.System.Models
{
    public class MovieWatched
    {
        public int userId { get; set; }

        public int movieId { get; set; }

        public MovieWatched(int userId, int movieId)
        {
            this.userId = userId;
            this.movieId = movieId;
        }

    }
}