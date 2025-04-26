using Sistem_Ticket_OOP.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Ticket_OOP
{
    public class SystemTickets
    {
        private List<Developer> _developer = new List<Developer>();
        private List<Ticket> _ticket = new List<Ticket>();

        public List<Developer> ObtenerDevelopers()
        {
            return _developer.ToList();
        }

        public List<Ticket> ObtenerTickets()
        {
            return _ticket.ToList();
        }

        public void AgregarDeveloper(Developer developer)
        {
            _developer.Add(developer);
        }

        public void AgregarTickets(Ticket ticket)
        {
            _ticket.Add(ticket);
        }



    }
}
