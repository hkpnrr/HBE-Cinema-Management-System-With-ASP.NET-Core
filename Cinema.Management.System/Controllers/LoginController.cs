using Microsoft.AspNetCore.Mvc;
using Cinema.Management.System.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Management.System.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
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
