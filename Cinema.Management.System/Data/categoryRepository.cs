using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Management.System.Data
{
    public class categoryRepository
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message+" getCategoryIdByName");
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message+" SendCategoryToDatabase");
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
                Console.WriteLine("ifden öncesi");
                while (reader.Read())
                {
                    Console.WriteLine("ifin içi");
                    Console.WriteLine("ifden içinde "+Convert.ToString(reader[0]));
                    allCategoryNames.Add(Convert.ToString(reader[0]));
                    
                }
                

                reader.Close(); // işin bitince kapat
            }
            //hata olursa vereceğim mesaj.
            catch (Exception e)
            {
                Console.WriteLine(e.Message+" getAllCategoryNames");
            }
            //Bağlantımı kapatıyorum
            finally
            {
                conn.Close();
            }

            foreach (var item in allCategoryNames)
            {
                Console.WriteLine(item);
            }

            return allCategoryNames;
        }
    }
}