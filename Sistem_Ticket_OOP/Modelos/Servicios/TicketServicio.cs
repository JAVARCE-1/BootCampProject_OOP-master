using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Ticket_OOP.Modelos.Servicios
{
    public class TicketServicio : ITicketServicio
    {
        public void AsignarTicket(SystemTickets sistema)
        {
            Console.WriteLine("Dame el id del Ticket: ");
            int ticketId = int.Parse(Console.ReadLine());

            if (ticketId < 0)
            {
                throw new ArgumentException("El id del Ticket debe ser mayor que 0");
            }

            var ticket = sistema.ObtenerTicketPorId(ticketId);
            if (ticket == null)
            {
                throw new ArgumentException("El id del Ticket no esta registrado");
            }

            Console.WriteLine("Dame el id del Developer: ");
            int developerId = int.Parse(Console.ReadLine());

            //usuario
            if (developerId < 0)
            {
                throw new ArgumentException("El id del Developer debe ser mayor que 0");
            }
            var developer = sistema.ObtenerDeveloperPorId(developerId);
            if (developer == null)
            {
                throw new ArgumentException("El id del Developer no esta registrado");
            }

            sistema.AsignarUsuarioTicket(developer, ticketId);
            sistema.AddTicketsToDeveloper(developer, ticket);
            Console.WriteLine($"\n El Ticket con el ID: {ticketId}  fue asignado al Developer {developer.Nombre}");

        }

        public void ActualizarStatusTicket(SystemTickets sistema)
        {
            Console.WriteLine("Dame el id del Ticket: ");
            int ticketId = int.Parse(Console.ReadLine());

            if (ticketId < 0)
            {
                throw new ArgumentException("El id del Ticket debe ser mayor que 0");
            }

            var tickets = sistema.ObtenerTicketPorId(ticketId);
            if (tickets == null)
            {
                Console.WriteLine("No hay ningun Ticket");
                return;
            }

            sistema.UpdateTicketRealizado(ticketId);
            Console.WriteLine($"\n Ticket con el ID: {tickets.Id} fue realizado");


        }

        public void AgregarTicket(SystemTickets sistema)
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
                Status = TicketStatus.Pendiente,
                Priority = priority,
                ReportBy = reportBy,
                CreadteDate = DateTime.Today,
            };

            sistema.AgregarTickets(tickets);
            Console.WriteLine($"\n Ticket agregado con el ID: {tickets.Id}");
        }

        public void EliminarTicket(SystemTickets sistema)
        {
            Console.WriteLine("Dame el id del Ticket: ");
            int ticketId = int.Parse(Console.ReadLine());
            if (ticketId < 0)
            {
                throw new ArgumentException("El id del Ticket debe ser mayor que 0");
            }

            var ticket = sistema.ObtenerTicketPorId(ticketId);
            if (ticket == null)
            {
                Console.WriteLine("No hay ningun Ticket");
                return;
            }
            sistema.DeleteTicket(ticketId);
            Console.WriteLine($"\n El Ticket con el ID: {ticketId} se elimino");
        }

        public void MostrarTicket(SystemTickets sistema)
        {
            var tickets = sistema.ObtenerTickets();

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

        public void MostrarTicketPorId(SystemTickets sistema)
        {
            throw new NotImplementedException();
        }

        public void ReporteTicketPorCreacion(SystemTickets sistema)
        {
            throw new NotImplementedException();
        }

        public void ReporteTicketPorDeveloper(SystemTickets sistema)
        {
            Console.WriteLine("Dame el id del Developer: ");
            int idDeveloper = int.Parse(Console.ReadLine());

            if (idDeveloper < 0)
            {
                throw new ArgumentException("El id del Developer debe ser mayor que 0");
            }

            var listadoTicketUsuarios = sistema.ObtenerTicketPorUsuarioId(idDeveloper);
            if (listadoTicketUsuarios.Count == 0)
            {
                Console.WriteLine("No hay ningun Ticket");
                return;
            }

            Console.WriteLine("Lista de Tickets por usuario asignado");
            Console.WriteLine("ID\t\tTitulo\tCategoria\tStatus\tUsuario Asignado\tRole");
            Console.WriteLine("-------------------------------------");
            foreach (var lista in listadoTicketUsuarios)
            {
                Console.WriteLine($"{lista.Id}\t{lista.Title}\t{lista.Category}\t{lista.Status}\t{lista.AssignedTo.Nombre}\t{lista.AssignedTo.Role}");
            }
        }

        public void ReporteTicketPriority(SystemTickets sistema)
        {
            Console.WriteLine("-> Ingrese Priority del Ticket ( 0=Baja ó 1=Medio ó 2=Alta): ");
            Priority priority = (Priority)Convert.ToInt32(Console.ReadLine());

            var tickets = sistema.ObtenerTicketPorPrioridad(priority);
            Console.WriteLine("");
            Console.WriteLine("== Lista de Tickets por Prioridad ==");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("ID\tTitle\t\t\t\tReported By\t\tStatus\t\tPriority\tCategory\tCreatedDated");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            foreach (var ticket in tickets)
            {
                Console.WriteLine($"{ticket.Id}\t{ticket.Title}\t\t\t{ticket.ReportBy} \t{ticket.Status}\t\t{ticket.Priority} \t\t{ticket.Category} \t{ticket.CreadteDate}  ");
            }




        }
    }
}
