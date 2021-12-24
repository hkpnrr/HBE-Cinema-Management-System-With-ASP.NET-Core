using Microsoft.AspNetCore.Mvc;
using Cinema.Management.System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Management.System.Controllers
{
    public class MainPageController : Controller
    {
        //
        private MovieService _movieService = new MovieService();

        public IActionResult MainPage()
        {
            return View();
        }

        public IActionResult MoviePage()
        {
            //
            Movie mov = _movieService.getMovie();


            return View(mov);
        }
    }
}
