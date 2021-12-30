using Microsoft.AspNetCore.Mvc;
using Cinema.Management.System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Management.System.Data;

namespace Cinema.Management.System.Controllers
{
    public class TicketPageController : Controller
    {
        public IActionResult CreateTicket(int id) // Create ticket according to movieId
        {
            Movie movieDetail = movieRepository.getMovieById(id);


            return View(movieDetail);
        }


        public IActionResult PayTicket() // Pay ticket
        {
            


            return View();
        }

    }
}
