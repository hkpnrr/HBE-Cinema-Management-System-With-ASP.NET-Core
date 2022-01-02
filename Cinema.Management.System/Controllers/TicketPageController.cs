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
        
        public IActionResult ChooseSession(int id,int sessionId) // Create ticket according to movieId
        {

            if(sessionId!=0){
                
                Console.WriteLine(sessionId);

                return RedirectToAction("SeatPage",new {id=sessionId});
            }
            else{
                Movie movieDetail = movieRepository.getMovieById(id);
            List<sessionSelectViewModel> viewModel = new List<sessionSelectViewModel>();
           
            return View(sessionRepository.getSessionsByMovieId(id));
            }
            
        }

        public IActionResult SeatPage(int id) // Pay ticket
        {
            List<Seat> seats = seatRepository.getSeatsBySessionId(id);

            return View(seats);
        }
        

        public IActionResult PayTicket() // Pay ticket
        {
            


            return View();
        }

        

    }
}
