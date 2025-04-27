using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        void ICommentServicio.AsignarCommentTickets(SystemTickets sistema)
        {
            Console.WriteLine("Dame el ID del Ticket: ");
            int ticketId = int.Parse(Console.ReadLine());

            if (ticketId < 0)
            {
                throw new ArgumentException("El id del Ticket debe ser mayor que 0");
            }

            var ticket = sistema.ObtenerTicketPorId(ticketId);
            if (ticket == null )
            {
                throw new ArgumentException("El id del Ticket no esta registrado");
            }

            Console.WriteLine("-> Dame el ID del Comment: ");
            int commentId = Convert.ToInt32(Console.ReadLine());
            if (commentId < 0)
            {
                throw new ArgumentException("El id del Comment debe ser mayor que 0");
            }
            var comment = sistema.ObtenerCommentId(commentId);
            if (comment == null)
            {
                Console.WriteLine("El id del Ticket no esta registrado");
                return;
            }

            sistema.AddCommentTicket(ticket, comment);
            //ticket.Comment.Add(comment);
            Console.WriteLine($"El Comment ID: {comment.Id} se asigno al Ticket ID: {ticket.Id} ");
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

        void ICommentServicio.ReporteCommentxTickets(SystemTickets sistema)
        {
            var tickets = sistema.ObtenerTickets();
            if (tickets.Count == 0)
            {
                Console.WriteLine("No hay ningun Tickets");
                return;
            }

            Console.WriteLine("");
            Console.WriteLine("== Lista de Comment con Tickets==");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Ticket_ID\tTitle Ticket\t\t\tComment_ID\t\t\tText Comment  ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            foreach (var ticket in tickets)
            {
                if (ticket.Comment != null)
                {
                    Console.Write($"{ticket.Id}\t{ticket.Title}   ");

                    foreach (var comment in ticket.Comment)
                    {
                        Console.Write($"{comment.Id}\t{comment.Autor}\t\t{comment.CreateDate}\t\t{comment.Text}    ");
                    }
                    Console.WriteLine("");
                }

            }

        }
    }
}
