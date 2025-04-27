using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Ticket_OOP.Modelos.Servicios
{
    public class CommentServicio : ICommentServicio
    {
        void ICommentServicio.AgregarComment(SystemTickets sistema)
        {
            Console.WriteLine("\nAgregar un nuevo Comment: ");

            Console.WriteLine("-> Ingrese Nombre del Author: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("-> Ingrese Text del Comment: ");
            string text = Console.ReadLine();


            var comment = new Comment
            {
                Autor = nombre,
                Text = text,
                CreateDate = DateTime.Now,
            };

            sistema.AgregarComment(comment);
            Console.WriteLine($"\n Comment agregado con el ID: {comment.Id}");
        }

        void ICommentServicio.MostrarComment(SystemTickets sistema)
        {
            var comments = sistema.ObtenerComments();
            if (comments.Count == 0)
            {
                Console.WriteLine("No hay ningun Comment");
                return;
            }

            Console.WriteLine("");
            Console.WriteLine("== Lista de Comment ==");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("ID\tAuthor\t\t\tCreateDate\t\t\tText Comment  ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            foreach (var comment in comments)
            {
                Console.WriteLine($"{comment.Id}\t{comment.Autor}\t\t{comment.CreateDate}\t\t{comment.Text}    ");
            }

        }
    }
}
