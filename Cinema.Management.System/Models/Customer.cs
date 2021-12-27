using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Management.System.Models
{
    public class Customer
    {

        public int userId{get;set;}
        public string email { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string birthDate { get; set; }
        public string phone { get; set; }
        public string address { get; set; }

        public Customer( string email, string password, string firstName, string lastName, string birthDate, string phone)
        {
           
           this.email = email;
           this.password = password;
           this.firstName = firstName;
           this.lastName = lastName;
           this.birthDate = birthDate;
           this.phone = phone;
           
        }

        public Customer( int userId,string password, string firstName, string lastName, string email, string birthDate, string phone)
        {
           this.userId=userId;
           this.email = email;
           this.password = password;
           this.firstName = firstName;
           this.lastName = lastName;
           this.birthDate = birthDate;
           this.phone = phone;
           
        }

        public Customer(string email,string password){
            this.email=email;
            this.password=password;
        }
    }
}
