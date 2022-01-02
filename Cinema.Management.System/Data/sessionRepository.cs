using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Management.System.Models;
using Cinema.Management.System.ViewModels;

namespace Cinema.Management.System.Data
{
    public class sessionRepository
    {
        private static string connString;
        private static SqlConnection conn;
        private static SqlCommand comm;
        public static void connectToDatabase()
        {
            connString = @"Data Source=.\SQLEXPRESS;Database=movie_database;Trusted_Connection=True;MultipleActiveResultSets=true"; //ConfigurationManager.ConnectionStrings["DatabaseUrl"].ConnectionString;
            conn = new SqlConnection(connString);

        }
        public static List<sessionSelectViewModel> getSessionsByMovieId(int movieId){

             connectToDatabase();

            comm = new SqlCommand("SELECT * FROM  (SELECT SESSION.*, CINEMA_HALL.cinemaHallName, CINEMA_HALL.amountOfSeats,CINEMA_HALL.cinemaHallAddress FROM SESSION INNER JOIN CINEMA_HALL ON SESSION.cinemahallId= CINEMA_HALL.cinemaHallId) AS T1  INNER JOIN MOVIE ON  T1.movieId = MOVIE.movieId WHERE MOVIE.movieId = @movieId", conn);
            comm.Parameters.AddWithValue("@movieId", movieId);
            SqlDataReader reader;
            
            sessionSelectViewModel temp=null;
            List<sessionSelectViewModel> sessionList= new List<sessionSelectViewModel>(); 
            try
            {
                conn.Open();

                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                     temp = new sessionSelectViewModel(new Session(Convert.ToInt32(reader[0]),Convert.ToInt32(reader[1]),Convert.ToInt32(reader[2]),Convert.ToString(reader[3])),new CinemaHall(Convert.ToString(reader[4]),Convert.ToInt32(reader[5]),Convert.ToString(reader[6])),new Movie(Convert.ToInt32(reader[7]),Convert.ToString(reader[8]),Convert.ToString(reader[9]),Convert.ToInt32(reader[10]),Convert.ToString(reader[11]),Convert.ToString(reader[12]),Convert.ToInt32(reader[13]),(bool)reader[14],Convert.ToString(reader[15]),Convert.ToString(reader[16])));
                     sessionList.Add(temp);
                }
                

                reader.Close(); // işin bitine kapat
            }
            //hata olursa vereceğim mesaj.
            catch (Exception e)
            {
                Console.WriteLine(e.Message +"getSessionsByMovieId");
            }
            //Bağlantımı kapatıyorum
            finally
            {
                conn.Close();
            }


            return sessionList;
        }

        public static int getSessionWithAllParameters(int movieId,int cinemaHallId,string sessionTime){

             connectToDatabase();

            comm = new SqlCommand("SELECT sessionId FROM SESSION WHERE movieId=@movieId AND cinemahallId=@cinemaHallId AND time=@sessionTime", conn);
            comm.Parameters.AddWithValue("@movieId", movieId);
            comm.Parameters.AddWithValue("@cinemaHallId", cinemaHallId);
            comm.Parameters.AddWithValue("@sessionTime", sessionTime);
            SqlDataReader reader;
            
            int sessionId=-1;
            try
            {
                conn.Open();

                reader = comm.ExecuteReader();

                if (reader.Read())
                {
                     sessionId=Convert.ToInt32(reader[0]);
                }
                

                reader.Close(); // işin bitine kapat
            }
            //hata olursa vereceğim mesaj.
            catch (Exception e)
            {
                Console.WriteLine(e.Message +"get session ıd");
            }
            //Bağlantımı kapatıyorum
            finally
            {
                conn.Close();
            }


            return sessionId;
        }
    }
}