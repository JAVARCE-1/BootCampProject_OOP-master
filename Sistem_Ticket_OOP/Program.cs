using Sistem_Ticket_OOP.Utilidades;

namespace Sistem_Ticket_OOP
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Inventory Management System ===\n");
            SystemTickets sistema = new SystemTickets();
            CargarDatos.CargarDatosIniciales(sistema);
            MenuUI.CargarMenuPrincipal(sistema);
        }
    }
}
