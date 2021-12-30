using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Management.System.Models;

namespace Cinema.Management.System.Data
{
    public class cinemaHallRepository
    {
        private static List<CinemaHall> _cinemaHalls = null;
        private static string connString;
        private static SqlConnection conn;
        private static SqlCommand comm;

        public static void connectToDatabase()
        {
            connString = @"Data Source=.\SQLEXPRESS;Database=movie_database;Trusted_Connection=True;MultipleActiveResultSets=true"; //ConfigurationManager.ConnectionStrings["DatabaseUrl"].ConnectionString;
            conn = new SqlConnection(connString);

        }


        public static List<CinemaHall> getAllCinemaHalls()
        {
            connectToDatabase();

            _cinemaHalls = new List<CinemaHall>();

            comm = new SqlCommand("SELECT * FROM CINEMA_HALL", conn);
            CinemaHall cinemaHall = null;

            SqlDataReader reader;
            try
            {

                //Bağlantımı açıyorum.
                conn.Open();
                //Reader nesnem için sql komutumu çalıştırıyorum
                reader = comm.ExecuteReader();

                //if (reader.HasRows)
                //{

                //}


                while (reader.Read()) // her seferinde tablodaki komple bir satırı okuyacak
                {
                    // reader[0] bir tane kolon'a denk geliyor
                    //Console.WriteLine(String.Format("{0}", reader[0]));
                    cinemaHall = new CinemaHall(Convert.ToInt32(reader[0]), Convert.ToString(reader[1]),
                     Convert.ToInt32(reader[2]), Convert.ToString(reader[3]));

                    _cinemaHalls.Add(cinemaHall);
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

            Console.WriteLine("Cinema Hall: " + _cinemaHalls[0].cinemaHallName);

            return _cinemaHalls;

        }

    }
}