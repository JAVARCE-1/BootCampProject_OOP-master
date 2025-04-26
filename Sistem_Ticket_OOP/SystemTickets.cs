using Sistem_Ticket_OOP.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public Developer ObtenerDeveloperoPorId(int developerId)
        {
            return _developer.FirstOrDefault(t => t.Id == developerId)!;
        }

        public List<Ticket> ObtenerTickets()
        {
            return _ticket.ToList();
        }
        public Ticket ObtenerTicketPorId(int ticketId)
        {
            return _ticket.FirstOrDefault(t => t.Id == ticketId)!;
        }

        public void AgregarDeveloper(Developer developer)
        {
            _developer.Add(developer);
        }

        public void AgregarTickets(Ticket ticket)
        {
            _ticket.Add(ticket);
        }

        public List<Ticket> ObtenerTicketPorUsuarioId(int developerId)
        {
            return _ticket.Where(m => m.AssignedTo.Id == developerId).ToList();
        }

        public void AsignarUsuarioTicket(Developer developer, int ticketId)
        {
            var ticket = _ticket.FirstOrDefault(p => p.Id == ticketId);
            if (ticket != null)
            {
                ticket.AssignedTo = developer;
                ticket.UpdateteDate = DateTime.Today;
            }
        }

        public List<Ticket> ObtenerTicketPorPrioridad(Priority prioridad)
        {
            return _ticket.Where(m => m.Priority == prioridad).ToList();
        }

    }
}
