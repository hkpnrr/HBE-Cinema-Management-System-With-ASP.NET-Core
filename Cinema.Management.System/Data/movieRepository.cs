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

        private static List<Movie> _movies = null;
        private static Movie movie = null;

        private static List<Actor> _actorsById = null;


        private static string connString;
        private static SqlConnection conn;
        private static SqlCommand comm;

        public static void connectToDatabase()
        {
            connString = @"Data Source=.\SQLEXPRESS;Database=movie_database;Trusted_Connection=True;MultipleActiveResultSets=true"; //ConfigurationManager.ConnectionStrings["DatabaseUrl"].ConnectionString;
            conn = new SqlConnection(connString);

        }

        /* public static List<Movie> getAllMovies()
        {
            connectToDatabase();

            _movies= new List<Movie>();

            comm = new SqlCommand("SELECT * FROM MOVIE", conn);
            Movie movie = null;

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
                    movie = new Movie(Convert.ToInt32(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]),
                        Convert.ToInt32(reader[3]), Convert.ToString(reader[4]), Convert.ToString(reader[5]),
                         Convert.ToInt32(reader[6]), (bool)reader[7],Convert.ToString(reader[8]),Convert.ToString(reader[9]));

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

        } */

        public static List<Movie> getAllMovies()
        {
            connectToDatabase();

            _movies = new List<Movie>();

            comm = new SqlCommand("SELECT  * FROM (SELECT MOVIE.movieId,MOVIE.movieName,MOVIE.moviereleaseDate,MOVIE.movieDuration,MOVIE.movieTrailerUrl,MOVIE.movieSummary,MOVIE.movieDirectorId,MOVIE.ısShowing,MOVIE.moviePhotoUrl,MOVIE.moviePosterUrl,T1.categoryName FROM MOVIE INNER JOIN (SELECT CATEGORY.categoryName,MOVIE_HAS_CATEGORIES.movieId FROM MOVIE_HAS_CATEGORIES INNER JOIN CATEGORY ON CATEGORY.categoryId=MOVIE_HAS_CATEGORIES.categoryId) AS T1 ON MOVIE.movieId=T1.movieId) AS T3 INNER JOIN DIRECTOR ON T3.movieDirectorId=DIRECTOR.directorId", conn);
            Movie movie = null;

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
                    movie = new Movie(Convert.ToInt32(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]),
                        Convert.ToInt32(reader[3]), Convert.ToString(reader[4]), Convert.ToString(reader[5]),
                         Convert.ToInt32(reader[6]), (bool)reader[7], Convert.ToString(reader[8]), Convert.ToString(reader[9]),
                         Convert.ToString(reader[10]), Convert.ToString(reader[12]), Convert.ToString(reader[13]));

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



        public static Movie getMovieById(int movieId)
        {

            connectToDatabase();
            comm = new SqlCommand("SELECT * FROM (SELECT  * FROM (SELECT MOVIE.movieId,MOVIE.movieName,MOVIE.moviereleaseDate,MOVIE.movieDuration,MOVIE.movieTrailerUrl,MOVIE.movieSummary,MOVIE.movieDirectorId,MOVIE.ısShowing,MOVIE.moviePhotoUrl,MOVIE.moviePosterUrl,T1.categoryName FROM MOVIE INNER JOIN (SELECT CATEGORY.categoryName,MOVIE_HAS_CATEGORIES.movieId FROM MOVIE_HAS_CATEGORIES INNER JOIN CATEGORY ON CATEGORY.categoryId=MOVIE_HAS_CATEGORIES.categoryId) AS T1 ON MOVIE.movieId=T1.movieId) AS T3 INNER JOIN DIRECTOR ON T3.movieDirectorId=DIRECTOR.directorId)AS T4 WHERE T4.movieId = @movieId", conn);
            comm.Parameters.AddWithValue("@movieId", movieId);
            SqlDataReader reader;

            try
            {


                conn.Open();

                reader = comm.ExecuteReader();

                if (reader.Read())
                {
                    movie = new Movie(Convert.ToInt32(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]),
                        Convert.ToInt32(reader[3]), Convert.ToString(reader[4]), Convert.ToString(reader[5]),
                     Convert.ToInt32(reader[6]), (bool)reader[7], Convert.ToString(reader[8]), Convert.ToString(reader[9]),
                     Convert.ToString(reader[10]), Convert.ToString(reader[12]), Convert.ToString(reader[13]));
                }
                else
                {

                }

                reader.Close(); // işin bitine kapat
            }
            //hata olursa vereceğim mesaj.
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //Bağlantımı kapatıyorum
            finally
            {
                conn.Close();
            }


            return movie;
        }

        public static List<Actor> getActorsById()
        {
            connectToDatabase();

            _actorsById = new List<Actor>();

            comm = new SqlCommand("SELECT ACTOR.*,MOVIE_HAS_ACTORS.movieId FROM ACTOR INNER JOIN MOVIE_HAS_ACTORS ON ACTOR.actorId=MOVIE_HAS_ACTORS.actorId", conn);
            //comm.Parameters.AddWithValue("@movieId", movieId);
            _actorsById = null;
            Actor actor= null;

            SqlDataReader reader;
            try
            {

                //Bağlantımı açıyorum.
                conn.Open();
                //Reader nesnem için sql komutumu çalıştırıyorum
                reader = comm.ExecuteReader();

                
                while (reader.Read()) // her seferinde tablodaki komple bir satırı okuyacak
                {
                    // reader[0] bir tane kolon'a denk geliyor
                    //Console.WriteLine(String.Format("{0}", reader[0]));
                    actor = new Actor(Convert.ToInt32(reader[0]),Convert.ToString(reader[1]),Convert.ToString(reader[2]));

                    _actorsById.Add(actor);
                }

                reader.Close(); // işin bitine kapat
            }
            //hata olursa vereceğim mesaj.
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //Bağlantımı kapatıyorum
            finally
            {
                conn.Close();
            }

            foreach (Actor item in _actorsById)
            {
                Console.WriteLine(item.actorFirstName+" "+item.actorLastName);
                
            }

            return _actorsById;
        } 


    }
}