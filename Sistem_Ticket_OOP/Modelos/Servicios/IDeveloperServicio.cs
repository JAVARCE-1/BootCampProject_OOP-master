using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Ticket_OOP.Modelos.Servicios
{
    interface IDeveloperServicio
    {
        void AgregarDeveloper(SystemTickets sistema);
        void MostrarDeveloper(SystemTickets sistema);
        void MostrarDeveloperPorId(SystemTickets sistema);

        void ReporteDevelopersConTicketID(SystemTickets sistema);
    }
}
