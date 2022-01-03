using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Management.System.Models;

namespace Cinema.Management.System.ViewModels
{
    public class ProfileViewModel
    {
        public Customer customer { get; set; }
        public List<Movie> watchedMovies { get; set; }

        public ProfileViewModel(Customer customer, List<Movie> watchedMovies)
        {
            this.customer = customer;
            this.watchedMovies = watchedMovies;
        }
    }
}