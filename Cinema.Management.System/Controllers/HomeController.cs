using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cinema.Management.System.Models;
using System.Data.SqlClient;
using Cinema.Management.System.Data;


namespace Cinema.Management.System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Register(string Name, string Surname, string Email, string Password, string Date, string Tel)
        {


            if (!(Name == null) && !(Surname == null) && !(Email == null) && !(Password == null) && !(Date == null) && !(Tel == null))
            {
                customerRepository.getAllEmails();
                if (customerRepository._emails != null && !customerRepository._emails.Contains(Email))
                {

                    Customer c = new Customer(Email, Password, Name, Surname, Date, Tel);


                    customerRepository.createCustomer(c);

                    return RedirectToAction("Login");
                }
                else if (customerRepository._emails == null)
                {
                    Customer c = new Customer(Email, Password, Name, Surname, Date, Tel);

                    customerRepository.createCustomer(c);

                    return RedirectToAction("Login");

                }
                else
                {

                    if (!(Name == null) && !(Surname == null) && !(Email == null) && !(Password == null) && !(Date == null) && !(Tel == null))
                    {
                        TempData["EmailError"] = "Email has already taken";
                    }

                    return RedirectToAction("Register");
                }
            }

            return View();

        }

        public IActionResult Login(string Email, string Password)
        {

            customerRepository.authUser = null;

            if (Email != null && Password != null)
            {
                if (Email.Equals("DEUCENG@gmail.com") && Password.Equals("123"))
                {
                    return RedirectToAction("Login", "AdminMainPage", new { area = "AdminMainPage" });
                }


                Customer c = new Customer(Email, Password);
                customerRepository.LoginAuthorization(c);
                if (customerRepository.authUser == null)
                {

                    TempData["LoginError"] = "Wrong Email or Password";
                }
                else
                {
                    return RedirectToAction("Login", "MainPage", new { area = "MainPage" });
                }
            }

            return View();
        }


    }
}
