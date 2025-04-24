using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos_POO.Modelos
{
    class SistemaAlquiler
    {
        private List<Vehiculo> _vehiculo = new List<Vehiculo>();
        private List<Cliente> _cliente = new List<Cliente>();


        public void AgregarCliente(Cliente cliente)
        {
            _cliente.Add(cliente);
        }

        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            _vehiculo.Add(vehiculo);
        }

        public List<Vehiculo> ObtenerVehiculos()
        {
            return _vehiculo.ToList();
        }

        public List<Cliente> ObtenerCliente()
        {
            return _cliente.ToList();
        }

        public Vehiculo ObtenerVehiculoPorId(int id)
        {
            return _vehiculo.FirstOrDefault(t => t.Id == id);
        }

    }
}
