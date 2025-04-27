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
                Console.WriteLine("1. Gestion de Developers");
                Console.WriteLine("2. Gestion de Tickets");
                Console.WriteLine("3. Gestion de Comments");
                Console.WriteLine("4. Reportes");
                Console.WriteLine("0. Salir");

                Console.WriteLine("\n Seleccione una opción: ");

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
                            GestionComments(sistema);
                            break;
                        case 4:
                            ListaReportes(sistema);
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

        private static void GestionComments(SystemTickets sistema)
        {
            bool regresar = false;
            ICommentServicio servicio = new CommentServicio();
            while (!regresar)
            {
                Console.WriteLine("\nGestion de Comments: ");
                Console.WriteLine("\nSeleccione una opcion: ");
                Console.WriteLine("1. Agregar un Comment");
                Console.WriteLine("2. Ver lista de Comment");
                Console.WriteLine("3. Asignar Comments to Ticket");
                Console.WriteLine("0. Regresar al menu principal");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        servicio.AgregarComment(sistema);
                        break;
                    case "2":
                        servicio.MostrarComment(sistema);
                        break;
                    case "3":
                        servicio.AsignarCommentTickets(sistema);
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
                Console.WriteLine("3. Asignar Ticket");
                Console.WriteLine("4. Modificar Tickets a Realizado");
                Console.WriteLine("5. Eliminar Ticket");
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
                        servicio.AsignarTicket(sistema);
                        break;
                    case "4":
                        servicio.ActualizarStatusTicket(sistema);
                        break;
                    case "5":
                        servicio.EliminarTicket(sistema);
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

        static void ListaReportes(SystemTickets sistema)
        {
            bool regresar = false;
            ITicketServicio servicioReporte1 = new TicketServicio();
            IDeveloperServicio servicioReporte2 = new DeveloperServicio();
            ICommentServicio servicioReporte3 = new CommentServicio();

            while (!regresar)
            {
                Console.WriteLine("\nReportes: ");
                Console.WriteLine("\nSeleccione una opcion: ");
                Console.WriteLine("1. Tickets por Usuario");
                Console.WriteLine("2. Tickets por fecha de Creación");
                Console.WriteLine("3. Obtener Comentarios por Tickets");
                Console.WriteLine("4. Usuarios con ID de sus Tickets");
                Console.WriteLine("5. Tickets por prioridad");
                Console.WriteLine("0. Regresar al menu principal");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        servicioReporte2.MostrarTicketPorDeveloperId(sistema);
                        break;
                    case "2":
                        servicioReporte1.ReporteTicketPorCreacion(sistema);
                        break;
                    case "3":
                        servicioReporte3.ReporteCommentxTickets(sistema);
                        break;
                    case "4":
                        servicioReporte2.ReporteDevelopersConTicketID(sistema);
                        break;
                    case "5":
                        servicioReporte1.ReporteTicketPriority(sistema);
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
