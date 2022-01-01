using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Management.System.Models;

namespace Cinema.Management.System.ViewModels
{
    public class MovieIsShowingViewModel
    {

        public List<Movie> isShowingMovies { get; set; }

        public List<Movie> notShowingMovies { get; set; }


        public MovieIsShowingViewModel(List<Movie> isShowingMovies, List<Movie> notShowingMovies)
        {
            this.isShowingMovies = isShowingMovies;
            this.notShowingMovies = notShowingMovies;
        }
    }
}