using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Ticket_OOP.Modelos
{
    public abstract class Persona

    {
        public string nombre { get; set; }
        public string genero { get; set; }
        public string dni { get; set; }
        public string direccion { get; set; }
        public int edad { get; set; }

    }
}
