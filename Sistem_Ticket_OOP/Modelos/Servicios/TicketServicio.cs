using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Ticket_OOP.Modelos.Servicios
{
    public class TicketServicio : ITicketServicio
    {
        void ITicketServicio.AgregarTicket(SystemTickets sistema)
        {
            Console.WriteLine("\nAgregar un nuevo Ticket: ");

            Console.WriteLine("-> Ingrese Title del Ticket: ");
            string title = Console.ReadLine();

            Console.WriteLine("-> Ingrese Description Ticket: ");
            string description = Console.ReadLine();

            Console.WriteLine("-> Ingrese Priority del Ticket ( 0=Baja ó 1=Medio ó 2=Alta): ");
            Priority priority = (Priority)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-> Ingrese Category del Ticket:  (0=Incidencia ó 1=Requerimiento)");
            TicketCategory categoryTicket = (TicketCategory)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-> Ingrese Report By: ");
            string reportBy = Console.ReadLine();

            var tickets = new Ticket
            {
                Title = title,
                Description = description,
                Category = categoryTicket,
                Status = TicketStatus.Activo,
                Priority = priority,
                ReportBy = reportBy,
                CreadteDate = DateTime.Today,
            };

            sistema.AgregarTickets(tickets);
            Console.WriteLine($"\n Ticket agregado con el ID: {tickets.Id}");
        }

        void ITicketServicio.MostrarTicket(SystemTickets sistema)
        {
            var tickets = sistema.ObtenerTickets();

            // Validar si no hay developers
            if (tickets.Count == 0)
            {
                Console.WriteLine("No hay ningun Ticket");
                return;
            }

            Console.WriteLine("");
            Console.WriteLine("== Lista de Tickets ==");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("ID\tTitle\t\t\t\tReported By\t\tStatus\t\tPriority\tCategory\tCreatedDated");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            foreach (var ticket in tickets)
            {
                Console.WriteLine($"{ticket.Id}\t{ticket.Title}\t\t\t{ticket.ReportBy} \t{ticket.Status}\t\t{ticket.Priority} \t\t{ticket.Category} \t{ticket.CreadteDate}  ");
            }
        }

        void ITicketServicio.MostrarTicketPorId(SystemTickets sistema)
        {
            throw new NotImplementedException();
        }
    }
}
