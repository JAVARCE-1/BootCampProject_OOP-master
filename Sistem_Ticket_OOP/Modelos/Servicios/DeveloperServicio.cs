using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Ticket_OOP.Modelos.Servicios
{
    class DeveloperServicio : IDeveloperServicio
    {
        public void AgregarDeveloper(SystemTickets sistema)
        {
            Console.WriteLine("\nAgregar un nuevo Developer: ");

            Console.WriteLine("-> Ingrese Nombre del Developer: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("-> Ingrese DNI del Developer: ");
            string dni = Console.ReadLine();

            Console.WriteLine("-> Ingrese Rol del Developer: ");
            string role = Console.ReadLine();

            Console.WriteLine("-> Ingrese Seniority del Developer:  (Junior - Senior)");
            string senority = Console.ReadLine();

            Console.WriteLine("-> Ingrese la Edad del Developer: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-> Ingrese el genero del Developer: [ 0 = MASCULINO ó 1 = FEMENINO]");
            Genero genero = (Genero)Convert.ToInt32(Console.ReadLine()); // 0 = Masculino

            var developer = new Developer
            {
                Nombre = nombre,
                Dni = dni,
                Role = role,
                Seniority = senority,
                Edad = edad,
                Genero = genero,
            };

            sistema.AgregarDeveloper(developer);
            Console.WriteLine($"\n Developer agregado con el ID: {developer.Id}");
        }

        public void MostrarDeveloper(SystemTickets sistema)
        {
            var developers = sistema.ObtenerDevelopers();

            // Validar si no hay developers
            if (developers.Count == 0)
            {
                Console.WriteLine("No hay ningun Developer");
                return;
            }

            Console.WriteLine("");
            Console.WriteLine("== Lista de Developers ==");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("ID\tNombre\t\t\tDni\t\t\tRole\t\t\tSeniority\tGenero\t\tEdad ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            foreach (var developer in developers)
            {
                Console.WriteLine($"{developer.Id}\t{developer.Nombre}\t\t{developer.Dni}\t\t{developer.Role}\t\t{developer.Seniority}\t\t{developer.Genero}\t{developer.Edad}   ");
            }
        }

         public void MostrarTicketPorDeveloperId(SystemTickets sistema)
        {
            Console.WriteLine("-> Dame ID Developer: ");
            int developerId = Convert.ToInt32(Console.ReadLine());
            if (developerId < 0)
            {
                throw new ArgumentException("El id del Developer debe ser mayor que 0");
            }
             
            var developer = sistema.ObtenerDeveloperPorId(developerId);

            if (developer == null)
            {
                Console.WriteLine("No hay ningun Developer");
                return;
            }

            Console.WriteLine("");
            Console.WriteLine("== Lista de Developers con Tickets ==");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("Id_Developer\tNombre\t\tSeniority\tID_Ticket\tTicket_Title ");
            Console.WriteLine("----------------------------------------------------------------------------------------");

            List<Developer> oneDeveloper = new List<Developer> { developer };
            foreach (var assigned in oneDeveloper)
            {
                if (assigned.Ticket.Count > 0)
                {
                    Console.Write($"{assigned.Id}\t\t{assigned.Nombre}\t{assigned.Seniority}   ");
                    foreach (var ticket in assigned.Ticket)
                    {
                        Console.Write($"\t{ticket.Id} \t\t{ticket.Title} ");
                    }
                    Console.WriteLine("");
                }

            }
         }

 

        public void ReporteDevelopersConTicketID(SystemTickets sistema)
        {
            // listar usuarios con los ids de sus tickets
            var developers = sistema.ObtenerDevelopers();
            if (developers.Count == 0)
            {
                Console.WriteLine("No hay ningun Developer");
                return;
            }

            Console.WriteLine("");
            Console.WriteLine("== Lista de Developers con sus IdTickets ==");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("Id_Developer\tNombre\t\tSeniority\tID_Ticket\tTicket_Title ");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            foreach (var developer in developers)
            {
                if (developer.Ticket.Count > 0)
                {
                    Console.Write($"{developer.Id}\t\t{developer.Nombre}\t{developer.Seniority}   ");
                    foreach (var ticket in developer.Ticket)
                    {
                        Console.Write($"\t{ticket.Id} \t\t{ticket.Title} ");
                    }
                    Console.WriteLine("");
                }

            }
        }
    }
}
