using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Management.System.Models;
using Cinema.Management.System.ViewModels;

namespace Cinema.Management.System.Data
{
    public static class cinemaHallRepository
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


        public static List<CinemaHallsViewModel> getCinemaHallsWithMovies()
        {
            connectToDatabase();

            List<CinemaHallsViewModel> _cinemaHallsWithMovies = new List<CinemaHallsViewModel>();

            comm = new SqlCommand("SELECT T21.cinemahallId,  T21.cinemaHallName, T21.cinemaHallAddress,MOVIE.movieId, MOVIE.movieName, MOVIE.moviePhotoUrl FROM  (SELECT DISTINCT T20.movieId, T20.cinemahallId,T20.cinemaHallName, T20.cinemaHallAddress FROM (SELECT CINEMA_HALL.cinemaHallName, CINEMA_HALL.cinemaHallAddress, SESSION.* FROM SESSION INNER JOIN CINEMA_HALL ON CINEMA_HALL.cinemaHallId = SESSION.cinemahallId) AS T20) AS T21 INNER JOIN MOVIE ON T21.movieId=MOVIE.movieId", conn);
            CinemaHallsViewModel cinemaHallWithMovies = null;

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
                    cinemaHallWithMovies = new CinemaHallsViewModel(Convert.ToInt32(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]),
                     Convert.ToInt32(reader[3]), Convert.ToString(reader[4]), Convert.ToString(reader[5]));

                    _cinemaHallsWithMovies.Add(cinemaHallWithMovies);
                }

                reader.Close(); // işin bitine kapat
            }
            //hata olursa vereceğim mesaj.
            catch(Exception e)
            {
                Console.WriteLine(e.Message +"getCinemaHallsWithMovies");
            }
            //Bağlantımı kapatıyorum
            finally
            {
                conn.Close();
            }

            return _cinemaHallsWithMovies;

        }

        public static int getSeatNumberByCinemaHallId(int cinemaHallId)
        {


            connectToDatabase();



            comm = new SqlCommand("SELECT amountOfSeats FROM CINEMA_HALL WHERE cinemaHallId=@cinemaHallId", conn);
            comm.Parameters.AddWithValue("@cinemaHallId", cinemaHallId);

            int seatNumber = 0;
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


                if (reader.Read()) // her seferinde tablodaki komple bir satırı okuyacak
                {
                    // reader[0] bir tane kolon'a denk geliyor
                    //Console.WriteLine(String.Format("{0}", reader[0]));
                    seatNumber = Convert.ToInt32(reader[0]);
                }

                reader.Close(); // işin bitine kapat
            }
            //hata olursa vereceğim mesaj.
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " seat number çekme");
            }
            //Bağlantımı kapatıyorum
            finally
            {
                conn.Close();
            }


            return seatNumber;
        }

    }
}