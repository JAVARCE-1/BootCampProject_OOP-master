using AlquilerVehiculos_POO.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos_POO.Interfaces
{
    public class VehiculoServicio : IVehiculoServicio
    {
        void IVehiculoServicio.AgregarVehiculo(SistemaAlquiler sistema)
        {
            throw new NotImplementedException();
        }

        void IVehiculoServicio.MostrarVehiculo(SistemaAlquiler sistema)
        {
            var vehiculos = sistema.ObtenerVehiculos();

            // Validar si no hay productos
            if (vehiculos.Count == 0)
            {
                Console.WriteLine("No hay ningun Vehiculos");
                return;
            }

            Console.WriteLine("Lista de Vehiculos");
            Console.WriteLine("ID\tMarca\tModelo\tPlaca\tPrecio\tColor\tAnio\tEstado\tPrecioAlquiler");
            Console.WriteLine("-------------------------------------");
            foreach (var vehiculo in vehiculos)
            {
                Console.WriteLine($"{vehiculo.Id}\t{vehiculo.Marca}\t{vehiculo.Modelo}\t{vehiculo.Placa}\t{vehiculo.Color}\t{vehiculo.Anio}\t{vehiculo.Estado}\t{vehiculo.PrecioAlquiler} ");
            }
        }
    }
}
