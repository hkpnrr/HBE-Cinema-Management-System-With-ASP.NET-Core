using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Management.System.Models;
using Cinema.Management.System.ViewModels;

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



            return _movies;
        }

        public static List<Movie> getAllMoviesByisShowing(bool isShowing)
        {
            connectToDatabase();

            _movies = new List<Movie>();

            comm = new SqlCommand("SELECT  * FROM (SELECT MOVIE.movieId,MOVIE.movieName,MOVIE.moviereleaseDate,MOVIE.movieDuration,MOVIE.movieTrailerUrl,MOVIE.movieSummary,MOVIE.movieDirectorId,MOVIE.ısShowing,MOVIE.moviePhotoUrl,MOVIE.moviePosterUrl,T1.categoryName FROM MOVIE INNER JOIN (SELECT CATEGORY.categoryName,MOVIE_HAS_CATEGORIES.movieId FROM MOVIE_HAS_CATEGORIES INNER JOIN CATEGORY ON CATEGORY.categoryId=MOVIE_HAS_CATEGORIES.categoryId) AS T1 ON MOVIE.movieId=T1.movieId) AS T3 INNER JOIN DIRECTOR ON T3.movieDirectorId=DIRECTOR.directorId WHERE ısShowing = @isShowing", conn);
            comm.Parameters.AddWithValue("@isShowing", isShowing);
            Movie movie = null;

            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();


                while (reader.Read()) // her seferinde tablodaki komple bir satırı okuyacak
                {
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
                Console.WriteLine("bir hata oluştu ishowing çekerken");
            }
            //Bağlantımı kapatıyorum
            finally
            {
                conn.Close();
            }



            return _movies;
        }



        public static Movie getMovieWithCategoryAndDirectorByMovieId(int movieId)
        {

            connectToDatabase();
            comm = new SqlCommand("SELECT  * FROM (SELECT MOVIE.movieId,MOVIE.movieName,MOVIE.moviereleaseDate,MOVIE.movieDuration,MOVIE.movieTrailerUrl,MOVIE.movieSummary,MOVIE.movieDirectorId,MOVIE.ısShowing,MOVIE.moviePhotoUrl,MOVIE.moviePosterUrl,T1.categoryName,T1.categoryId FROM MOVIE INNER JOIN (SELECT CATEGORY.categoryName,MOVIE_HAS_CATEGORIES.* FROM MOVIE_HAS_CATEGORIES INNER JOIN CATEGORY ON CATEGORY.categoryId=MOVIE_HAS_CATEGORIES.categoryId) AS T1 ON MOVIE.movieId=T1.movieId) AS T3 INNER JOIN DIRECTOR ON T3.movieDirectorId=DIRECTOR.directorId WHERE movieId=@movieId", conn);
            comm.Parameters.AddWithValue("@movieId", movieId);
            SqlDataReader reader;
            
            Movie movieTemp=null;
            try
            {
                conn.Open();

                reader = comm.ExecuteReader();

                if (reader.Read())
                {
                    

                     movieTemp=new Movie(Convert.ToInt32(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]),
                        Convert.ToInt32(reader[3]), Convert.ToString(reader[4]), Convert.ToString(reader[5]),
                     Convert.ToInt32(reader[6]), (bool)reader[7], Convert.ToString(reader[8]), Convert.ToString(reader[9]),
                     Convert.ToString(reader[10]),Convert.ToInt32(reader[11]),Convert.ToInt32(reader[12]), Convert.ToString(reader[13]), Convert.ToString(reader[14]));
                }
                else
                {

                }

                reader.Close(); // işin bitine kapat
            }
            //hata olursa vereceğim mesaj.
            catch (Exception e)
            {
                Console.WriteLine(e.Message +"getMovieWithCategoryAndDirectorByMovieId");
            }
            //Bağlantımı kapatıyorum
            finally
            {
                conn.Close();
            }


            return movieTemp;
        }

        public static void editMovie(Movie mov)
        {

            
            try
            {
                connectToDatabase();
                conn.Open();

                

                int movieId = mov.movieId;
                string movieName = mov.movieName;
                string movieReleaseDate = mov.movieReleaseDate;
                int movieDuration = mov.movieDuration;
                string movieTrailerUrl = mov.movieTrailerUrl;
                string movieSummary = mov.movieSummary;
                bool isShowing = mov.isShowing;
                int directorId=mov.directorId;
                string moviePhotoUrl = mov.moviePhotoUrl;
                string moviePosterUrl = mov.moviePosterUrl;


                comm = new SqlCommand("UPDATE MOVIE SET movieName = @movieName, movieReleaseDate = @movieReleaseDate, movieDuration = @movieDuration, movieTrailerUrl=@movieTrailerUrl, movieSummary = @movieSummary,movieDirectorId=@MovieDirectorId, ısShowing = @isShowing, moviePhotoUrl = @moviePhotoUrl, moviePosterUrl = @moviePosterUrl  WHERE movieId = @movieId", conn);
                comm.Parameters.AddWithValue("@movieId", movieId);
                comm.Parameters.AddWithValue("@movieName", movieName);
                comm.Parameters.AddWithValue("@movieReleaseDate", movieReleaseDate);
                comm.Parameters.AddWithValue("@movieDuration", movieDuration);
                comm.Parameters.AddWithValue("@movieTrailerUrl", movieTrailerUrl);
                comm.Parameters.AddWithValue("@movieSummary", movieSummary);
                comm.Parameters.AddWithValue("@isShowing", isShowing);
                comm.Parameters.AddWithValue("@moviePhotoUrl", moviePhotoUrl);
                comm.Parameters.AddWithValue("@MovieDirectorId", directorId);
                comm.Parameters.AddWithValue("@moviePosterUrl", moviePosterUrl);

                int result = comm.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " edit movie in admin");
            }
            finally
            {
                conn.Close();
            }
        }

        public static Movie getMovieById(int movieId)
        {

            connectToDatabase();
            comm = new SqlCommand("SELECT  * FROM (SELECT MOVIE.movieId,MOVIE.movieName,MOVIE.moviereleaseDate,MOVIE.movieDuration,MOVIE.movieTrailerUrl,MOVIE.movieSummary,MOVIE.movieDirectorId,MOVIE.ısShowing,MOVIE.moviePhotoUrl,MOVIE.moviePosterUrl,T1.categoryName,T1.categoryId FROM MOVIE INNER JOIN (SELECT CATEGORY.categoryName,MOVIE_HAS_CATEGORIES.* FROM MOVIE_HAS_CATEGORIES INNER JOIN CATEGORY ON CATEGORY.categoryId=MOVIE_HAS_CATEGORIES.categoryId) AS T1 ON MOVIE.movieId=T1.movieId) AS T3 INNER JOIN DIRECTOR ON T3.movieDirectorId=DIRECTOR.directorId WHERE movieId=@movieId", conn);
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
                    comment = new Comment(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]), Convert.ToString(reader[2]),
                    Convert.ToString(reader[3]), Convert.ToString(reader[4]));

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


        public static List<Comment> getAllComments()
        {
            connectToDatabase();

            _comments = new List<Comment>();

            comm = new SqlCommand("SELECT T16.*, MOVIE.movieName FROM (SELECT T15.commentId, T15.movieId ,T15.userId,T15.firstName, T15.lastName, T15.commentContent FROM (SELECT CUSTOMER.*,COMMENTS.commentId, COMMENTS.commentContent,COMMENTS.movieId FROM COMMENTS INNER JOIN CUSTOMER ON CUSTOMER.userId = COMMENTS.userId) AS T15) AS T16 INNER JOIN MOVIE ON T16.movieId=MOVIE.movieId ORDER BY T16.movieId", conn);


            Comment comment = null;

            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();

                while (reader.Read()) // her seferinde tablodaki komple bir satırı okuyacak
                {
                    // reader[0] bir tane kolon'a denk geliyor
                    comment = new Comment(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]), Convert.ToInt32(reader[2]), Convert.ToString(reader[3]),
                    Convert.ToString(reader[4]), Convert.ToString(reader[5]), Convert.ToString(reader[6]));

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


        public static int deleteCommentById(int commentId)
        {
            int result = 0;

            connectToDatabase();
            try
            {
                conn.Open();

                string sql = "delete from COMMENTS where commentId=@commentId";
                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.AddWithValue("@commentId", commentId);

                result = command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }


            return result;
        }

        public static Actor getActorsByName(string actorName, string actorSurname)
        {
            connectToDatabase();



            comm = new SqlCommand("SELECT * FROM ACTOR WHERE actorName=@actorName AND actorSurname=@actorSurname", conn);
            comm.Parameters.AddWithValue("@actorName", actorName);
            comm.Parameters.AddWithValue("@actorSurname", actorSurname);
            actor = null;

            SqlDataReader reader;
            try
            {

                //Bağlantımı açıyorum.
                conn.Open();
                //Reader nesnem için sql komutumu çalıştırıyorum
                reader = comm.ExecuteReader();


                if (reader.Read()) // her seferinde tablodaki komple bir satırı okuyacak
                {
                    // reader[0] bir tane kolon'a denk geliyor
                    //Console.WriteLine(String.Format("{0}", reader[0]));
                    actor = new Actor(Convert.ToInt32(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]));


                }

                reader.Close(); // işin bitine kapat
            }
            //hata olursa vereceğim mesaj.
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "aktor çekme hatası");
            }
            //Bağlantımı kapatıyorum
            finally
            {
                conn.Close();
            }



            return actor;
        }


        public static void createActor(string actorName, string actorSurname)
        {

            try
            {
                connectToDatabase();
                conn.Open();

                comm = new SqlCommand("INSERT INTO ACTOR (actorName, actorSurname) VALUES(@actorName, @actorSurname)", conn);
                comm.Parameters.AddWithValue("@actorName", actorName);
                comm.Parameters.AddWithValue("@actorSurname", actorSurname);


                int result = comm.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " create actor error");
            }
            finally
            {
                conn.Close();
            }
        }

        public static int getActorIdByName(string actorName, string actorSurname)
        {
            connectToDatabase();



            comm = new SqlCommand("SELECT actorId FROM ACTOR WHERE actorName=@actorName AND actorSurname=@actorSurname", conn);
            comm.Parameters.AddWithValue("@actorName", actorName);
            comm.Parameters.AddWithValue("@actorSurname", actorSurname);
            int actorId = -1;

            SqlDataReader reader;
            try
            {

                //Bağlantımı açıyorum.
                conn.Open();
                //Reader nesnem için sql komutumu çalıştırıyorum
                reader = comm.ExecuteReader();


                if (reader.Read()) // her seferinde tablodaki komple bir satırı okuyacak
                {
                    // reader[0] bir tane kolon'a denk geliyor
                    //Console.WriteLine(String.Format("{0}", reader[0]));
                    actorId = Convert.ToInt32(reader[0]);


                }

                reader.Close(); // işin bitine kapat
            }
            //hata olursa vereceğim mesaj.
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "aktor id çekme hatası");
            }
            //Bağlantımı kapatıyorum
            finally
            {
                conn.Close();
            }



            return actorId;
        }


        public static void SendActorAndMovieRelationToDatabase(int actorId, int movieId)
        {

            try
            {
                connectToDatabase();
                conn.Open();

                comm = new SqlCommand("INSERT INTO MOVIE_HAS_ACTORS (actorId, movieId) VALUES(@actorId,@movieId)", conn);
                comm.Parameters.AddWithValue("@actorId", actorId);
                comm.Parameters.AddWithValue("@movieId", movieId);


                int result = comm.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " create actor movie relation error");
            }
            finally
            {
                conn.Close();
            }
        }


        public static Session GetSessionByMovieIdAndCinemaHallId(int movieId, int cinemaHallId,string sessionTime)
        {

            connectToDatabase();
            comm = new SqlCommand("SELECT * FROM SESSION WHERE movieId=@movieId AND cinemahallId=@cinemaHallId AND time=@sessionTime", conn);
            comm.Parameters.AddWithValue("@movieId", movieId);
            comm.Parameters.AddWithValue("@cinemaHallId", cinemaHallId);
            comm.Parameters.AddWithValue("@sessionTime", sessionTime);
            Session session = null;

            SqlDataReader reader;
            try
            {

                //Bağlantımı açıyorum.
                conn.Open();
                //Reader nesnem için sql komutumu çalıştırıyorum
                reader = comm.ExecuteReader();


                if (reader.Read()) // her seferinde tablodaki komple bir satırı okuyacak
                {
                    // reader[0] bir tane kolon'a denk geliyor
                    //Console.WriteLine(String.Format("{0}", reader[0]));

                    session = new Session(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]), Convert.ToInt32(reader[2]), Convert.ToString(reader[3]),Convert.ToInt32(reader[4]));

                }

                reader.Close(); // işin bitine kapat
            }
            //hata olursa vereceğim mesaj.
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "session  çekme hatası");
            }
            //Bağlantımı kapatıyorum
            finally
            {
                conn.Close();
            }




            return session;
        }

        public static void CreateSession(int movieId, int cinemaHallId, string sessionTime,int sessionPrice)
        {
            try
            {
                connectToDatabase();
                conn.Open();

                comm = new SqlCommand("INSERT INTO SESSION (movieId, cinemaHallId,time,price) VALUES(@movieId, @cinemaHallId,@sessionTime,@sessionPrice)", conn);
                comm.Parameters.AddWithValue("@movieId", movieId);
                comm.Parameters.AddWithValue("@cinemaHallId", cinemaHallId);
                comm.Parameters.AddWithValue("@sessionTime", sessionTime);
                comm.Parameters.AddWithValue("@sessionPrice", sessionPrice);


                int result = comm.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " create session error");
            }
            finally
            {
                conn.Close();
            }
        }

        public static List<Session> GetAllSession()
        {
            connectToDatabase();
            comm = new SqlCommand("SELECT * FROM SESSION", conn);
            List<Session> _allSessions = new List<Session>();
            Session session = null;

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

                    session = new Session(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]), Convert.ToInt32(reader[2]), Convert.ToString(reader[3]),Convert.ToInt32(reader[4]));
                    _allSessions.Add(session);
                }

                reader.Close(); // işin bitine kapat
            }
            //hata olursa vereceğim mesaj.
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "all session  çekme hatası");
            }
            //Bağlantımı kapatıyorum
            finally
            {
                conn.Close();
            }




            return _allSessions;
        }


        public static List<CinemaHall> getAllCinemaHalls()
        {

            connectToDatabase();
            comm = new SqlCommand("SELECT * FROM CINEMA_HALL", conn);
            List<CinemaHall> _allCinemaHalls = new List<CinemaHall>();
            CinemaHall cinemaHall = null;

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

                    cinemaHall = new CinemaHall(Convert.ToInt32(reader[0]), Convert.ToString(reader[1]), Convert.ToInt32(reader[2]), Convert.ToString(reader[3]));
                    _allCinemaHalls.Add(cinemaHall);
                }

                reader.Close(); // işin bitine kapat
            }
            //hata olursa vereceğim mesaj.
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "all cinemahall  çekme hatası");
            }
            //Bağlantımı kapatıyorum
            finally
            {
                conn.Close();
            }




            return _allCinemaHalls;
        }


        public static int deleteSessionById(int sessionId)
        {
            int result = 0;

            connectToDatabase();
            try
            {
                conn.Open();

                string sql = "delete from SESSION where sessionId=@sessionId";
                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.AddWithValue("@sessionId", sessionId);

                result = command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }


            return result;
        }


    }
}