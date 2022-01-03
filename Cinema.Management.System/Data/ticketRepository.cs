using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Management.System.Models;

namespace Cinema.Management.System.Data
{
    public static class ticketRepository
    {
        private static string connString;
        private static SqlConnection conn;
        private static SqlCommand comm;
        public static void connectToDatabase()
        {
            connString = @"Data Source=.\SQLEXPRESS;Database=movie_database;Trusted_Connection=True;MultipleActiveResultSets=true"; //ConfigurationManager.ConnectionStrings["DatabaseUrl"].ConnectionString;
            conn = new SqlConnection(connString);

        }

        public static void CreateTicket(int userId,int sessionId,int seatId){
            

            try
            {
                connectToDatabase();
                conn.Open();

                comm = new SqlCommand("INSERT INTO TICKET (userId, sessionId,seatId) VALUES(@userId, @sessionId,@seatId)", conn);
                comm.Parameters.AddWithValue("@userId", userId);
                comm.Parameters.AddWithValue("@sessionId", sessionId);
                comm.Parameters.AddWithValue("@seatId", seatId);

                int result = comm.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " create ticket");
            }
            finally
            {
                conn.Close();
            }
        }

        public static Ticket findTicketGeneralInfoBySessionId(int sessionId){

            connectToDatabase();
            comm = new SqlCommand("SELECT T1.time,T1.price,T1.cinemaHallName,MOVIE.movieName FROM  (SELECT SESSION.*, CINEMA_HALL.cinemaHallName FROM SESSION INNER JOIN CINEMA_HALL ON SESSION.cinemahallId= CINEMA_HALL.cinemaHallId) AS T1  INNER JOIN MOVIE ON  T1.movieId = MOVIE.movieId WHERE T1.sessionId = @sessionId", conn);
            comm.Parameters.AddWithValue("@sessionId", sessionId);
            SqlDataReader reader;

            
            Ticket ticket=null;

            try
            {


                conn.Open();

                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    ticket=new Ticket(Convert.ToString(reader[0]),Convert.ToInt32(reader[1]),Convert.ToString(reader[2]),Convert.ToString(reader[3]));
                    
                }
                

                reader.Close(); // işin bitine kapat
            }
            //hata olursa vereceğim mesaj.
            catch (Exception e)
            {
                Console.WriteLine(e.Message+" ticket get info");
            }
            //Bağlantımı kapatıyorum
            finally
            {
                conn.Close();
            }


            
            return ticket;
        }

        public static void deleteTicketBySessionId(int sessionId){
            

            connectToDatabase();
            try
            {
                conn.Open();

                string sql = "delete from TICKET where sessionId=@sessionId";
                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.AddWithValue("@sessionId", sessionId);

                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message+ "DELETE TİCKET");
            }
            finally
            {
                conn.Close();
            }

        }
    }
}