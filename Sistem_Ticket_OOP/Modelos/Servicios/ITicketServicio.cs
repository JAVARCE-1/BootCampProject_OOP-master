using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Ticket_OOP.Modelos.Servicios
{
    interface ITicketServicio
    {
        void AgregarTicket(SystemTickets sistema);
        void MostrarTicket(SystemTickets sistema);
        void MostrarTicketPorId(SystemTickets sistema);

        void EliminarTicket(SystemTickets sistema);

        void ActualizarStatusTicket(SystemTickets sistema);

        void ReporteTicketPorDeveloper(SystemTickets sistema);
        void ReporteTicketPorCreacion(SystemTickets sistema);
        void ReporteTicketPriority(SystemTickets sistema);

        void AsignarTicket(SystemTickets sistema);
    }
}
