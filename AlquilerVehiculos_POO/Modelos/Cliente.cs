using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos_POO.Modelos
{
    public class Cliente
    {
        private static int _nextId = 1;

        public int Id { get; set; }
        public string Dni { get; set; }
        public string Nombre { get; set; }

        public string LicenciaConducir { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public Estado Estado { get; set; }

        public Cliente()
        {
            Id = _nextId++;
        }
    }

}
