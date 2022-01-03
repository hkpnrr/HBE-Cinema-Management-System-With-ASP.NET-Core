using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Management.System.Models;

namespace Cinema.Management.System.Data
{
    public static class directorRepository
    {
        public static Director _director=null;
        private static string connString;
        private static SqlConnection conn;
        private static SqlCommand comm;
        public static void connectToDatabase()
        {
            connString = @"Data Source=.\SQLEXPRESS;Database=movie_database;Trusted_Connection=True;MultipleActiveResultSets=true"; //ConfigurationManager.ConnectionStrings["DatabaseUrl"].ConnectionString;
            conn = new SqlConnection(connString);

        }



        public static void GetDirectorByName(string DirectorFirstName, string DirectorLastName)
        {


            _director=null;

            connectToDatabase();
            
            comm = new SqlCommand(@"SELECT * FROM DIRECTOR WHERE directorName=@DirectorFirstName AND directorSurname=@DirectorLastName", conn);
            comm.Parameters.AddWithValue("@DirectorFirstName", DirectorFirstName);
            comm.Parameters.AddWithValue("@DirectorLastName", DirectorLastName);
            SqlDataReader reader;



            try
            {


                conn.Open();

                reader = comm.ExecuteReader();

                if (reader.Read())
                {
                    _director=new Director(Convert.ToInt32(reader[0]),Convert.ToString(reader[1]),Convert.ToString(reader[2]));
                    
                }
                else
                {

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




            


        }

        public static void CreateDirector(string DirectorFirstName, string DirectorLastName)
        {


            try
            {
                connectToDatabase();
                conn.Open();




                comm = new SqlCommand("INSERT INTO DIRECTOR (directorName,directorSurname) VALUES(@name, @surname)", conn);
                comm.Parameters.AddWithValue("@name", DirectorFirstName);
                comm.Parameters.AddWithValue("@surname", DirectorLastName);
                

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
    }
}