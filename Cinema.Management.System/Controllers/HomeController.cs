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
        private CustomerService _customerService = new CustomerService();
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

        public IActionResult Register(string Name,string Surname,string Email,string Password,string Date,string Tel)
        {
            Console.WriteLine(HttpContext.Request.Query["Name"].ToString());
            Console.WriteLine(HttpContext.Request.Query["Surname"].ToString());

            if(!(Name==null) && !(Surname==null) && !(Email==null) && !(Password==null) && !(Date==null) && !(Tel==null)){
                if( customerRepository._emails!=null && !customerRepository._emails.Contains(Email)){
                
                Customer c=new Customer(Email,Password,Name,Surname,Date,Tel);
                

                customerRepository.createCustomer(c);
            }
            else if(customerRepository._emails==null){
                Customer c=new Customer(Email,Password,Name,Surname,Date,Tel);

                customerRepository.createCustomer(c);
            }
            }

            

            return View();
        }

         public IActionResult Login()
        {
            _customerService.getCustomer();
            DateTime saat =DateTime.Now;

            // ViewBag, Model, ViewData, ViewModels


            ViewBag.Saat = saat;

            return View();
        }


        [HttpPost]
        public IActionResult Login(Customer cs)
        {
            //Get connection string from web.config file  
            string connString = "Server=DESKTOP-77SAD3C\\SQLEXPRESS;Database=denemece;Trusted_Connection=True;MultipleActiveResultSets=true"; //ConfigurationManager.ConnectionStrings["DatabaseUrl"].ConnectionString;


            SqlConnection conn = new SqlConnection(connString);

            string sqlQuery = "SELECT email,password FROM CUSTOMER where email=@email AND password=@password";

            SqlCommand comm = new SqlCommand(sqlQuery, conn);

            comm.Parameters.AddWithValue("@email", cs.email);
            comm.Parameters.AddWithValue("@password", cs.password);

            SqlDataReader reader;
            try
            {

                //Bağlantımı açıyorum.
                conn.Open();
                //Reader nesnem için sql komutumu çalıştırıyorum
                reader = comm.ExecuteReader();

                if (reader.Read())
                {
                    return RedirectToAction("MainPage");
                }
                else
                {
                    ViewData["Message"] = "User Login Failed !";
                }

                reader.Close(); // işin bitine kapat
            }
            //hata olursa vereceğim mesaj.
            catch
            {
                Console.WriteLine("bir hata oluştu");
            }
            //Bağlantımı kapatıyorum
            finally
            {
                conn.Close();
            }

            return View();
        }
    }
}
