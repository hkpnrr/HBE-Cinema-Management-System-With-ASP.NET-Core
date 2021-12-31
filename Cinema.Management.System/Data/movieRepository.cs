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

        public static List<Movie> _movies = null;
        private static Movie movie = null;

        private static List<Actor> _actorsById = null;
        private static Actor actor = null;
        public static List<string> _moviesName = null;

        private static List<Comment> _comments = null;
        private static Comment comment = null;

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
            actor = null;

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
                    actor = new Actor(Convert.ToInt32(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToInt32(reader[3]));

                    _actorsById.Add(actor);
                }

                reader.Close(); // işin bitine kapat
            }
            //hata olursa vereceğim mesaj.
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "AKTÖR HATASI XD");
            }
            //Bağlantımı kapatıyorum
            finally
            {
                conn.Close();
            }

            foreach (Actor item in _actorsById)
            {
                Console.WriteLine(item.actorFirstName + " " + item.actorLastName);

            }

            return _actorsById;
        }


        public static List<Movie> getAllMovieNames()
        {
            connectToDatabase();

            _moviesName = new List<string>();

            comm = new SqlCommand("SELECT movieName FROM MOVIE", conn);


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
                    _moviesName.Add(Convert.ToString(reader[0]));
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



            return _movies;
        }

        public static List<Comment> getAllCommentsByMovieId(int movieId)
        {
            connectToDatabase();

            _comments = new List<Comment>();

            comm = new SqlCommand("SELECT T15.movieId ,T15.userId,T15.firstName, T15.lastName, T15.commentContent FROM (SELECT CUSTOMER.*, COMMENTS.commentContent,COMMENTS.movieId FROM COMMENTS INNER JOIN CUSTOMER ON CUSTOMER.userId = COMMENTS.userId WHERE COMMENTS.movieId=@movieId) AS T15", conn);
            comm.Parameters.AddWithValue("@movieId", movieId);

            Comment comment = null;

            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();

                while (reader.Read()) // her seferinde tablodaki komple bir satırı okuyacak
                {
                    // reader[0] bir tane kolon'a denk geliyor
                    comment = new Comment(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToString(reader[4]));

                    _comments.Add(comment);
                }

                reader.Close(); // işin bitine kapat
            }
            //hata olursa vereceğim mesaj.
            catch
            {
                Console.WriteLine("bir hata oluştu comment okurken");
            }
            //Bağlantımı kapatıyorum
            finally
            {
                conn.Close();
            }

            return _comments;
        }

        public static void SendCommentToDatabase(Comment comment)
        {
            try
            {
                connectToDatabase();
                conn.Open();

                comm = new SqlCommand("INSERT INTO COMMENTS (movieId, userId, commentContent) VALUES(@movieId, @userId, @commentContent)", conn);
                comm.Parameters.AddWithValue("@movieId", comment.movieId);
                comm.Parameters.AddWithValue("@userId", comment.userId);
                comm.Parameters.AddWithValue("@commentContent", comment.commentContent);

                int result = comm.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " SendCommentToDatabase");
            }
            finally
            {
                conn.Close();
            }
        }

        public static void SendMovieToDatabase(Movie m)
        {


            try
            {
                connectToDatabase();
                conn.Open();

                comm = new SqlCommand("INSERT INTO MOVIE (movieName,moviereleaseDate,movieDuration,movieTrailerUrl,movieSummary,movieDirectorId,ısShowing,moviePhotoUrl,moviePosterUrl) VALUES(@movieName,@moviereleaseDate,@movieDuration,@movieTrailerUrl,@movieSummary,@directorId,@isShowing,@moviePhotoUrl,@moviePosterUrl)", conn);
                comm.Parameters.AddWithValue("@movieName", m.movieName);
                comm.Parameters.AddWithValue("@moviereleaseDate", m.movieReleaseDate);
                comm.Parameters.AddWithValue("@movieDuration", m.movieDuration);
                comm.Parameters.AddWithValue("@movieTrailerUrl", m.movieTrailerUrl);
                comm.Parameters.AddWithValue("@movieSummary", m.movieSummary);
                comm.Parameters.AddWithValue("@directorId", m.movieDirector.directorId);
                comm.Parameters.AddWithValue("@isShowing", m.isShowing);
                comm.Parameters.AddWithValue("@moviePhotoUrl", m.moviePhotoUrl);
                comm.Parameters.AddWithValue("@moviePosterUrl", m.moviePosterUrl);


                int result = comm.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " SendMovieToDatabase");
            }
            finally
            {
                conn.Close();
            }

        }


        public static int getMovieIdByName(string movieName)
        {

            connectToDatabase();
            comm = new SqlCommand("SELECT movieId FROM MOVIE WHERE movieName=@movieName", conn);
            comm.Parameters.AddWithValue("@movieName", movieName);
            SqlDataReader reader;

            int movieIdTemp = -1;

            try
            {


                conn.Open();

                reader = comm.ExecuteReader();

                if (reader.Read())
                {
                    movieIdTemp = Convert.ToInt32(reader[0]);
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


            return movieIdTemp;
        }






    }
}