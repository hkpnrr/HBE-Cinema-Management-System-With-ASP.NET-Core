using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Management.System.Models
{
    public class Director
    {
        public int directorId { get; set; }
        public string directorFirstName { get; set; }
        public string directorLastName { get; set; }

        public Director(int directorId,string firstName,string lastName)
        {
            this.directorId=directorId;
            this.directorFirstName=firstName;
            this.directorLastName=lastName;
        }

        public Director(string firstName,string lastName)
        {
            
            this.directorFirstName=firstName;
            this.directorLastName=lastName;
        }
    }
}