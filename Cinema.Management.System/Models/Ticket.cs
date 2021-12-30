using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Management.System.Models
{
    public class Ticket
    {
        public int ticketId { get; set; }

        public int userId { get; set; }

        public int sessionId { get; set; }

        public Ticket(int ticketId, int userId, int sessionId)
        {
            this.ticketId = ticketId;
            this.userId = userId;
            this.sessionId = sessionId;
        }
    }
}