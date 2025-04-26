using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Ticket_OOP.Modelos
{
    public class Ticket
    {
        private static int _nextId = 1;
        public int Id { get; private set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public TicketStatus Status { get; set; }
        public Priority Priority { get; set; }
        public TicketCategory Category { get; set; }
        public string ReportBy { get; set; }
        public DateTime CreadteDate { get; set; }
        public DateTime UpdateteDate { get; set; }

        //public Developer AssignedTo { get; set; }
        //public List<> Coment { get; set; }



        public Ticket()
        {

        }
    }
}