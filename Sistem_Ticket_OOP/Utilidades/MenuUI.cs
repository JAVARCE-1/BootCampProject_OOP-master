using Sistem_Ticket_OOP.Modelos.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Ticket_OOP.Utilidades
{
   public class MenuUI
    {
        public static void CargarMenuPrincipal(SystemTickets sistema)
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\nMenu Principal:");
                Console.WriteLine("1. Gestion de Developer");
                Console.WriteLine("2. Gestion de Tickets");
                Console.WriteLine("3. Reportes");
                Console.WriteLine("0. Salir");

                Console.WriteLine("\n Seleccione una opcion: ");

                try
                {
                    int opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            GestionDevelopers(sistema);
                            break;
                        case 2:
                            GestionTickets(sistema);
                            break;
                        case 3:
                            //MovimientosStock(sistema);

                            break;
                        case 0:
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Opcion invalida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static void GestionDevelopers(SystemTickets sistema)
        {
            bool regresar = false;
            IDeveloperServicio servicio = new DeveloperServicio();
            while (!regresar)
            {
                Console.WriteLine("\nGestion de Developer: ");
                Console.WriteLine("\nSeleccione una opcion: ");
                Console.WriteLine("1. Agregar un Developer");
                Console.WriteLine("2. Ver lista de Developer");
                Console.WriteLine("3. Ver Developer por Id");         
                Console.WriteLine("0. Regresar al menu principal");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        servicio.AgregarDeveloper(sistema);
                        break;
                    case "2":
                        servicio.MostrarDeveloper(sistema);
                        break;
                    case "3":
                        //servicio.MostrarEmpleadoPorId(sistema);
                        break;
                    case "4":
                        // MostrarTipoEmpleados(sistema);
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

        static void GestionTickets(SystemTickets sistema)
        {
            bool regresar = false;
            ITicketServicio servicio = new TicketServicio();
            while (!regresar)
            {
                Console.WriteLine("\nGestion de Tickets: ");
                Console.WriteLine("\nSeleccione una opcion: ");
                Console.WriteLine("1. Agregar un Ticket");
                Console.WriteLine("2. Ver lista de Ticket");
                Console.WriteLine("3. Ver Developer por Id");
                Console.WriteLine("0. Regresar al menu principal");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        servicio.AgregarTicket(sistema);
                        break;
                    case "2":
                        servicio.MostrarTicket(sistema);
                        break;
                    case "3":
                        //servicio.MostrarEmpleadoPorId(sistema);
                        break;
                    case "4":
                        // MostrarTipoEmpleados(sistema);
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


    }
}
