using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semita3.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string TicketTitle { get; set; }
        public string TicketDescription { get; set; }
        public string TicketSubmitter { get; set; }
        public int TicketPriority { get; set; }
        public string TicketStatus { get; set; }
        public DateTime TicketCreatedOn { get; set; }
        public DateTime TicketUpdatedOn { get; set; }
        public string TicketComment { get; set; }
    }
}
