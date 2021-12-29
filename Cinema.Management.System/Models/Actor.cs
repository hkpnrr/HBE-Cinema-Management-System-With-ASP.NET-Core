using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Management.System.Models
{
    public class Actor
    {
        public int actorId { get; set; }
        public string actorFirstName { get; set; }
        public string actorLastName { get; set; }

        public Actor(int actorId,string actorFirstName,string actorLastName)
        {
            this.actorId=actorId;
            this.actorFirstName=actorFirstName;
            this.actorLastName=actorLastName;
        }
    }
}