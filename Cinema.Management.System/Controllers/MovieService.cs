using Cinema.Management.System.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Management.System.Controllers
{
    public class MovieService
    {
        public Movie getMovie()
        {
            string connString = "Server=DESKTOP-77SAD3C\\SQLEXPRESS;Database=denemece;Trusted_Connection=True;MultipleActiveResultSets=true"; //ConfigurationManager.ConnectionStrings["DatabaseUrl"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm = new SqlCommand("SELECT * FROM MOVIE", conn);

            //SqlCommand comm = new SqlCommand("SELECT * FROM CUSTOMER WHERE NAME=@name, conn);
            //comm.Parameters.Add("@name", name);

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
                        Convert.ToInt32(reader[3]), Convert.ToString(reader[4]), Convert.ToString(reader[5]), Convert.ToInt32(reader[6]), (bool)reader[7]);
                    break;

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

            return movie;
        }

    }
}
