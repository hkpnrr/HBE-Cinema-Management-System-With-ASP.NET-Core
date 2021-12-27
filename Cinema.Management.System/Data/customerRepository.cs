using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Management.System.Models;

namespace Cinema.Management.System.Data
{
    public class customerRepository
    {
        public static List<string> _emails = null;

        public static Customer authUser;
        private static string connString;
        private static SqlConnection conn;
        private static SqlCommand comm;

        public static void connectToDatabase()
        {
            connString = @"Data Source=.\SQLEXPRESS;Database=movie_database;Trusted_Connection=True;MultipleActiveResultSets=true"; //ConfigurationManager.ConnectionStrings["DatabaseUrl"].ConnectionString;
            conn = new SqlConnection(connString);

        }

        public static List<string> getAllEmails()
        {
            connectToDatabase();

            _emails = new List<string>();

            comm = new SqlCommand("SELECT email FROM CUSTOMER", conn);


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
                    _emails.Add(Convert.ToString(reader[0]));
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



            return _emails;

        }

        public static void createCustomer(Customer c)
        {

            try
            {
                connectToDatabase();
                conn.Open();


                comm = new SqlCommand("INSERT INTO CUSTOMER (firstname,lastname,email,password,birthDate,phone) VALUES(@name, @surname, @email, @password, @birthDate, @phone)", conn);
                comm.Parameters.AddWithValue("@name", c.firstName);
                comm.Parameters.AddWithValue("@surname", c.lastName);
                comm.Parameters.AddWithValue("@email", c.email);
                comm.Parameters.AddWithValue("@password", c.password);
                comm.Parameters.AddWithValue("@birthDate", c.birthDate);
                comm.Parameters.AddWithValue("@phone", c.phone);

                int result = comm.ExecuteNonQuery();

                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }




        }

        public static Customer LoginAuthorization(Customer cs)
        {

            connectToDatabase();
            string sqlQuery = "SELECT * FROM CUSTOMER where email=@email AND password=@password";

            SqlCommand comm = new SqlCommand(sqlQuery, conn);

            comm.Parameters.AddWithValue("@email", cs.email);
            comm.Parameters.AddWithValue("@password", cs.password);

            SqlDataReader reader;
            try
            {

                //Bağlantımı açıyorum.
                conn.Open();
                //Reader nesnem için sql komutumu çalıştırıyorum
                reader = comm.ExecuteReader();

                if (reader.Read())
                {
                    authUser = new Customer(Convert.ToInt32(reader[0]), Convert.ToString(reader[1])
                    , Convert.ToString(reader[2]), Convert.ToString(reader[3]),
                   Convert.ToString(reader[4]), Convert.ToString(reader[5]), Convert.ToString(reader[6]));


                }
                else
                {
                    authUser = null;
                }

                reader.Close(); // işin bitine kapat
            }
            //hata olursa vereceğim mesaj.
            catch
            {
                Console.WriteLine("loginauthor bir hata oluştu");
            }
            //Bağlantımı kapatıyorum
            finally
            {
                conn.Close();
            }

            return authUser;
        }




    }
}