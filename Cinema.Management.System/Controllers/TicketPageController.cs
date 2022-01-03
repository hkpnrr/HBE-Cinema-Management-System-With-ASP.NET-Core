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

                return RedirectToAction("SeatPage",new {session=sessionId});
            }
            else{
                Movie movieDetail = movieRepository.getMovieById(id);
            List<sessionSelectViewModel> viewModel = new List<sessionSelectViewModel>();
           
            return View(sessionRepository.getSessionsByMovieId(id));
            }
            
        }

        public IActionResult SeatPage(int session,int seatId) // Pay ticket
        {
            if(seatId!=0){

                Console.WriteLine(seatId+"seat ıd");
                return RedirectToAction("PayTicket",new {seatNewId=seatId});
            }
            else{
                List<Seat> seats = seatRepository.getSeatsBySessionId(session);

            return View(seats);
            }
            
        }
        

        public IActionResult PayTicket(int seatNewId) // Pay ticket
        {
            
            //moviename cinemahallname sessiontime seatno sessionprice yazdırırken
            
            // seatNewId ile sessionıd bul

            int sessionId=sessionRepository.getSessionIdBySeatId(seatNewId);
            //for create ticket  userid  sessionıd 
            ticketRepository.CreateTicket(customerRepository.authUser.userId,sessionId,seatNewId);
            //seat i unavailable yap
            seatRepository.editSeatAvailableStatus(seatNewId);

            Ticket tempTicket = ticketRepository.findTicketGeneralInfoBySessionId(sessionId);
            string ticketTime=tempTicket.sessionTime;
            int ticketPrice=tempTicket.sessionPrice;
            string ticketCinemaHallName=tempTicket.cinemaHallName;
            string ticketMovieName=tempTicket.movieName;

            //find seat no
            int seatNo=seatRepository.getSeatNumberById(seatNewId);
            //find created ticket
            Ticket ticket = new Ticket(customerRepository.authUser.userId,sessionId,ticketMovieName,ticketCinemaHallName,ticketTime,seatNo,ticketPrice);

            return View(ticket);
        }

        

    }
}
