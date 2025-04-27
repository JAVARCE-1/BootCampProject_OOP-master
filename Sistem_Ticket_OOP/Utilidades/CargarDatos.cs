using Sistem_Ticket_OOP.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sistem_Ticket_OOP.Utilidades
{
    public class CargarDatos
    {
         
        public static void CargarDatosIniciales(SystemTickets sistema)
        {

            

            var ticket1 = new Ticket { 
                Title = "Error al enviar correo", 
                Description = "No se puede enviar correo a personas externas" ,
                Category = TicketCategory.Incidencia,
                Status = TicketStatus.Pendiente,
                Priority =Priority.Alta,
                ReportBy = "Servidesk",
                CreadteDate = new DateTime(2025, 1, 1),
            };
            sistema.AgregarTickets(ticket1);

            var ticket2 = new Ticket
            {
                Title = "Creacion de correo",
                Description = "Creacion de correo para nuevo personal del area RRHH",
                Category = TicketCategory.Requerimiento,
                Status = TicketStatus.Pendiente,
                Priority = Priority.Baja,
                ReportBy = "Carlos Peres",
                CreadteDate = new DateTime(2025, 3, 1),
            };
            sistema.AgregarTickets(ticket2);

            var ticket3 = new Ticket
            {
                Title = "Incidencia en la pagina web",
                Description = "No carga el portal web de la pagina",
                Category = TicketCategory.Incidencia,
                Status = TicketStatus.Pendiente,
                Priority = Priority.Media,
                ReportBy = "Jose",
                CreadteDate = new DateTime(2025, 3, 2),
            };
            sistema.AgregarTickets(ticket3);

            List<Ticket> ticketAsignado = new List<Ticket>() { ticket1 };

            var developer1 = new Developer
            {
                Nombre = "Juan Perez",
                Dni = "45645649",
                Role = "Developer",
                Seniority = "Junior",
                Edad = 28,
                Genero = Genero.Masculino,
                Ticket = ticketAsignado, 
                //Ticket = ticketAsignado, // new List<Ticket> { ticket1, ticket2 },
            };
            sistema.AgregarDeveloper(developer1);

            var developer2 = new Developer
            {
                Nombre = "Maria Flores",
                Dni = "48564534",
                Role = "Developer web",
                Seniority = "Senior",
                Edad = 31,
                Genero = Genero.Femenino,
            };
            sistema.AgregarDeveloper(developer2);

            var comment1 = new Comment
            {
                Autor = "Autor1",
                Text = "A continuacion se detalla el comentario acerca de la incidencia reportada....",
                CreateDate = new DateTime(2025, 3, 2)
            };
            sistema.AgregarComment(comment1);
        }
    }

}
