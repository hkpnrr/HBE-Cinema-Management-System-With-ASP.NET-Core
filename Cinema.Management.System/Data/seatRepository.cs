using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Management.System.Models;

namespace Cinema.Management.System.Data
{
    public static class seatRepository
    {
        private static string connString;
        private static SqlConnection conn;
        private static SqlCommand comm;

        public static void connectToDatabase()
        {
            connString = @"Data Source=.\SQLEXPRESS;Database=movie_database;Trusted_Connection=True;MultipleActiveResultSets=true"; //ConfigurationManager.ConnectionStrings["DatabaseUrl"].ConnectionString;
            conn = new SqlConnection(connString);

        }


        public static List<Seat> getSeatsBySessionId(int sessionId){

            connectToDatabase();
            comm = new SqlCommand("SELECT * FROM SEAT WHERE sessionId=@sessionId", conn);
            comm.Parameters.AddWithValue("@sessionId", sessionId);
            SqlDataReader reader;

            List<Seat> seats =new List<Seat>();
            Seat seat=null;

            try
            {


                conn.Open();

                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    seat= new Seat(Convert.ToInt32(reader[0]),Convert.ToInt32(reader[1]),Convert.ToInt32(reader[2]),(bool)reader[3]);
                    seats.Add(seat);
                    
                }
                

                reader.Close(); // işin bitine kapat
            }
            //hata olursa vereceğim mesaj.
            catch 
            {
            }
            //Bağlantımı kapatıyorum
            finally
            {
                conn.Close();
            }


            return seats;
        }

        public static void CreateSeat(int seatNumber,int sessionId){

            try
            {
                connectToDatabase();
                conn.Open();

                comm = new SqlCommand("INSERT INTO SEAT (seatNumber, sessionId, isAvailable) VALUES(@seatNumber, @sessionId, 1)", conn);
                comm.Parameters.AddWithValue("@seatNumber", seatNumber);
                comm.Parameters.AddWithValue("@sessionId", sessionId);

                int result = comm.ExecuteNonQuery();


            }
            catch 
            {
            }
            finally
            {
                conn.Close();
            }

        }

        public static int deleteSeatsBySessionId(int sessionId)
        {
            int result = 0;

            connectToDatabase();
            try
            {
                conn.Open();

                string sql = "delete from SEAT where sessionId=@sessionId";
                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.AddWithValue("@sessionId", sessionId);

                result = command.ExecuteNonQuery();

            }
            catch 
            {
            }
            finally
            {
                conn.Close();
            }


            return result;
        }

        public static void editSeatAvailableStatus(int seatId)
        {

            
            try
            {
                connectToDatabase();
                conn.Open();
                comm = new SqlCommand("UPDATE SEAT SET isAvailable = 0  WHERE seatId = @seatId", conn);
                comm.Parameters.AddWithValue("@seatId", seatId);
                

                int result = comm.ExecuteNonQuery();

            }
            catch 
            {
               
            }
            finally
            {
                conn.Close();
            }
        }

        public static int getSeatNumberById(int seatId){
            connectToDatabase();
            comm = new SqlCommand("SELECT seatNumber FROM SEAT WHERE seatId=@seatId", conn);
            comm.Parameters.AddWithValue("@seatId", seatId);
            SqlDataReader reader;

            
            int seatNumber=-1;

            try
            {


                conn.Open();

                reader = comm.ExecuteReader();

                if (reader.Read())
                {
                    seatNumber=Convert.ToInt32(reader[0]);
                    
                }
                

                reader.Close(); // işin bitine kapat
            }
            //hata olursa vereceğim mesaj.
            catch 
            {
                
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