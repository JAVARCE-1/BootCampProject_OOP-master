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
        private List<Comment> _comment = new List<Comment>();

        //obtener datos por ID
        public Developer ObtenerDeveloperPorId(int developerId)
        {
            return _developer.FirstOrDefault(t => t.Id == developerId)!;
        }
        public Comment ObtenerCommentId(int commentId)
        {
            return _comment.FirstOrDefault(m => m.Id == commentId)!;
        }

        public Ticket ObtenerTicketPorId(int ticketId)
        {
            return _ticket.FirstOrDefault(t => t.Id == ticketId)!;
        }

        //listar clases
        public List<Developer> ObtenerDevelopers()
        {
            return _developer.ToList();
        }
        public List<Ticket> ObtenerTickets()
        {
            return _ticket.ToList();
        }
        public List<Comment> ObtenerComments()
        {
            return _comment.ToList();
        }


        //AGREGAR
        public void AgregarComment(Comment comment)
        {
            _comment.Add(comment);
        }
        public void AgregarDeveloper(Developer developer)
        {
            _developer.Add(developer);
        }

        public void AgregarTickets(Ticket ticket)
        {
            _ticket.Add(ticket);
        }


        //otros metodos
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
                ticket.Status = TicketStatus.Asignado;
            }
        }

        public List<Ticket> ObtenerTicketPorPrioridad(Priority prioridad)
        {
            return _ticket.Where(m => m.Priority == prioridad).ToList();
        }

        public void UpdateTicketRealizado(int ticketId)
        {
            var ticket = _ticket.FirstOrDefault(p => p.Id == ticketId);
            if (ticket != null)
            {
                ticket.UpdateteDate = DateTime.Today;
                ticket.Status = TicketStatus.Realizado;
            }
        }

        public void AddCommentTicket(Ticket ticket, Comment comment)
        {
            ticket.Comment.Add(comment);
        }
        public void AddTicketsToDeveloper(Developer developer, Ticket ticket)
        {
            developer.Ticket.Add(ticket);
        }

        public void DeleteTicket(int ticketId)
        {
            _ticket.RemoveAll(p => p.Id == ticketId);
        }
    }
}
