using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos_POO.Modelos
{
    public class Vehiculo
    {
        private static int _nextId = 1;

        public int Id { get; private set; }
        public string Placa { get; set; }
        public Marca Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public string Color { get; set; }
        public Estado Estado { get; set; }
        public decimal PrecioAlquiler { get; set; }

        public Vehiculo()
        {
            Id = _nextId++;
        }

    }

  
}
