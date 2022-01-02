using Microsoft.AspNetCore.Mvc;
using Cinema.Management.System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Management.System.Data;
using Cinema.Management.System.ViewModels;

namespace Cinema.Management.System.Controllers
{
    public class TicketPageController : Controller
    {
        public IActionResult ChooseSession(int id) // Create ticket according to movieId
        {

            Movie movieDetail = movieRepository.getMovieById(id);
            List<sessionSelectViewModel> viewModel = new List<sessionSelectViewModel>();
           
            return View(sessionRepository.getSessionsByMovieId(id));
        }
        

        public IActionResult PayTicket() // Pay ticket
        {
            


            return View();
        }

    }
}
