using AlquilerVehiculos_POO.Interfaces;
using AlquilerVehiculos_POO.Modelos;

namespace AlquilerVehiculos_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA ALQUILER DE VEHICULO");

            SistemaAlquiler sistema = new SistemaAlquiler();
            CargarDatosIniciales(sistema);

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\nMenu Principal:");
                Console.WriteLine("1. Gestion de Vehiculo");
                Console.WriteLine("2. Gestion de Cliente");
                Console.WriteLine("3. Alquiler Vehiculo");
                //Console.WriteLine("4. Reportes");
                Console.WriteLine("0. Salir");

                Console.WriteLine("\n Seleccione una opcion: ");

                try
                {
                    int opcion = int.Parse(Console.ReadLine());
                    // Entra aqui -> 
                    switch (opcion)
                    {
                        case 1:
                            GestionVehiculos(sistema);
                            break;
                        case 2:
                            //GestionProductos(sistema);
                            break;
                        case 3:
                            // MovimientosStock(sistema);
                            break;
                        case 4:
                            // MostrarReportes(sistema);
                            break;
                        case 0:
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Opcion invalida.");
                            break;
                    }
                }
                catch (Exception ex) // throw an error
                {
                    Console.WriteLine(ex.Message); // IndexOutOfRangeException // En internet
                }
            }

        }

        private static void GestionVehiculos(SistemaAlquiler sistema)
        {
            bool regresar = false;
            IVehiculoServicio servicio = new VehiculoServicio();

            while (!regresar)
            {
                Console.WriteLine("\nGestion de Vehiculos: ");
                Console.WriteLine("\nSeleccione una opcion: ");
                Console.WriteLine("1. Agregar un Vehiculo");
                Console.WriteLine("2. Ver lista de Vehiculos");
                //Console.WriteLine("3. Ver empleado por Id");
                //Console.WriteLine("4. Mostrar lista de tipos de empleados");
                Console.WriteLine("0. Regresar al menu principal");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        servicio.AgregarVehiculo(sistema);
                        break;
                    case "2":
                        servicio.MostrarVehiculo(sistema);
                        break;
                    case "0":
                        regresar = true;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }
            }
        }

        static void CargarDatosIniciales(SistemaAlquiler sistema)
        {
            // Agregar tipos de empleado
            //var tipoAdmin = new TipoEmpleado { Nombre = "Administrador", Descripcion = "Acceso total al sistema" };

            var vehiculo = new Vehiculo
            {
                Marca = Marca.Ford,
                Modelo = "Ford XLS",
                Placa = "XBF-345",
                Anio = 24,
                Color = "Azul",
                Estado = Estado.Activo,
                PrecioAlquiler = 550.99m
            };

            sistema.AgregarVehiculo(vehiculo);

        }
    }
}
