using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Management.System.Models;

namespace Cinema.Management.System.Data
{
    public static class categoryRepository
    {
        private static string connString;
        private static SqlConnection conn;
        private static SqlCommand comm;

        private static List<string> allCategoryNames = null;

        public static void connectToDatabase()
        {
            connString = @"Data Source=.\SQLEXPRESS;Database=movie_database;Trusted_Connection=True;MultipleActiveResultSets=true"; //ConfigurationManager.ConnectionStrings["DatabaseUrl"].ConnectionString;
            conn = new SqlConnection(connString);

        }
        public static int getCategoryIdByName(string categoryName)
        {

            connectToDatabase();
            comm = new SqlCommand("SELECT categoryId FROM CATEGORY WHERE categoryName=@categoryName", conn);
            comm.Parameters.AddWithValue("@categoryName", categoryName);
            SqlDataReader reader;

            int categoryIdTemp=-1;

            try
            {


                conn.Open();

                reader = comm.ExecuteReader();

                if (reader.Read())
                {
                    categoryIdTemp=Convert.ToInt32(reader[0]);
                    
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


            return categoryIdTemp;
        }

        public static void SendCategoryToDatabase(int categoryId,int movieId)
        {


            try
            {
                connectToDatabase();
                conn.Open();

                comm = new SqlCommand("INSERT INTO MOVIE_HAS_CATEGORIES (movieId,categoryId) VALUES(@movieId,@categoryId)", conn);
                comm.Parameters.AddWithValue("@movieId", movieId);
                comm.Parameters.AddWithValue("@categoryId", categoryId);
                
                

                comm.ExecuteNonQuery();

                
            }
            catch 
            {
               
            }
            finally
            {
                conn.Close();
            }


        }

        public static List<string> getAllCategoryNames()
        {

            connectToDatabase();
            allCategoryNames=new List<string>();
            comm = new SqlCommand("SELECT categoryName FROM CATEGORY", conn);
            
            SqlDataReader reader;

            

            try
            {


                conn.Open();

                reader = comm.ExecuteReader();
                
                while (reader.Read())
                {
                    
                    allCategoryNames.Add(Convert.ToString(reader[0]));
                    
                }
                

                reader.Close(); // işin bitince kapat
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

            

            return allCategoryNames;
        }

        public static List<Category> getAllCategory()
        {

            connectToDatabase();
            List<Category> allCategory=new List<Category>();
            comm = new SqlCommand("SELECT * FROM CATEGORY", conn);
            Category tempCategory=null;
            SqlDataReader reader;

            

            try
            {


                conn.Open();

                reader = comm.ExecuteReader();
                
                while (reader.Read())
                {
                    tempCategory=new Category(Convert.ToInt32(reader[0]),Convert.ToString(reader[1]));
                    allCategory.Add(tempCategory);
                    
                }
                

                reader.Close(); // işin bitince kapat
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

            

            return allCategory;
        }

        public static void editMovieHasCategory(int movieId,int categoryId)
        {

            
            try
            {
                connectToDatabase();
                conn.Open();

               


                comm = new SqlCommand("UPDATE MOVIE_HAS_CATEGORIES SET categoryId = @categoryId WHERE movieId = @movieId", conn);
                comm.Parameters.AddWithValue("@movieId", movieId);
                comm.Parameters.AddWithValue("@categoryId", categoryId);
                

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