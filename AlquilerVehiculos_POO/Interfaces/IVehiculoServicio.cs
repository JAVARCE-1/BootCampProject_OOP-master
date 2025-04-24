using AlquilerVehiculos_POO.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos_POO.Interfaces
{
    interface IVehiculoServicio
    {
        void AgregarVehiculo(SistemaAlquiler sistema);
        void MostrarVehiculo(SistemaAlquiler sistema);
    }
}
