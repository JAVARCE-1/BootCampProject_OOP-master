using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Ticket_OOP.Modelos.Servicios
{
    interface ICommentServicio
    {
        void AgregarComment(SystemTickets sistema);
        void MostrarComment(SystemTickets sistema);
    }
}
