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

        public void MostrarDeveloperPorId(SystemTickets sistema)
        {
            throw new NotImplementedException();
        }

        public void ListarDeveloperConTickets(SystemTickets sistema)
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
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("ID\tNombre\tRole\t\tSeniority\t\tTicket title\tDescription\tEstado\tPrecio_Alquiler");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            foreach (var developer in developers)
            {
                Console.WriteLine($"{developer.Id}\t{developer.Nombre}\t{developer.Role}\t{developer.Seniority}   ");
                foreach (var numero in developer.Ticket)
                {
                    Console.WriteLine(numero.Title + " ");
                }
            }
        }


    }
}
