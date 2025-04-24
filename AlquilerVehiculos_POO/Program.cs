namespace AlquilerVehiculos_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA ALQUILER DE VEHICULO");

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
                            //GestionEmpleados(sistema);
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
    }
}
