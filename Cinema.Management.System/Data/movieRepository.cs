using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Management.System.Models;

namespace Cinema.Management.System.Data
{
    public static class movieRepository
    {

        private static List<Movie> _movies = new List<Movie>();
        private static string connString;
        private static SqlConnection conn;
        private static SqlCommand comm;

        public static void connectToDatabase()
        {
            connString = @"Data Source=.\SQLEXPRESS;Database=movie_database;Trusted_Connection=True;MultipleActiveResultSets=true"; //ConfigurationManager.ConnectionStrings["DatabaseUrl"].ConnectionString;
            conn = new SqlConnection(connString);

        }

        public static List<Movie> getAllMovies()
        {
            connectToDatabase();

            comm = new SqlCommand("SELECT * FROM MOVIE", conn);
            Movie movie = null;

            SqlDataReader reader;
            try
            {
                Console.WriteLine("TRY DENEME31");

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
                    movie = new Movie(Convert.ToInt32(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]),
                        Convert.ToInt32(reader[3]), Convert.ToString(reader[4]), Convert.ToString(reader[5]), Convert.ToInt32(reader[6]), (bool)reader[7]);

                    _movies.Add(movie);
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

            Console.WriteLine(_movies[0].movieName + _movies[0].movieDuration);

            return _movies;

        }


    }
}