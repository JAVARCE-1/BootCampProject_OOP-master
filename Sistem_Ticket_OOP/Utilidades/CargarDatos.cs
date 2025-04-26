using Sistem_Ticket_OOP.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Ticket_OOP.Utilidades
{
    public class CargarDatos
    {
        public static void CargarDatosIniciales(SystemTickets sistema)
        {

            var ticket1 = new Ticket { 
                Title = "Error al enviar correo", 
                Description = "No se puede enviar correo a personas externas" ,
                Status = TicketStatus.Activo,
                Priority =Priority.Alta,
                ReportBy = "Carlos de RRHH",
                CreadteDate = new DateTime(2025, 1, 1),
                UpdateteDate =  new DateTime(2025, 1, 1),
            };
            sistema.AgregarTickets(ticket1);

            var ticket2 = new Ticket
            {
                Title = "Error al enviar correo",
                Description = "No se puede enviar correo a personas externas",
                Status = TicketStatus.Activo,
                Priority = Priority.Alta,
                ReportBy = "Carlos de RRHH",
                CreadteDate = new DateTime(2025, 1, 1),
                UpdateteDate = new DateTime(2025, 1, 1),
            };
            sistema.AgregarTickets(ticket2);

            var developer = new Developer
            {

                Role = "Desarrollador",
                Seniority = "Senior",
                //LISTA TICKEET

            };
            sistema.AgregarDeveloper(developer);
        }
    }

}
