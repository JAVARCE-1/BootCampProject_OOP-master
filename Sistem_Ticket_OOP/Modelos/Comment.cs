using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Ticket_OOP.Modelos
{
    public class Comment
    {
        private static int _nextId = 1;
        public  int Id { get; private set; }
        public string Autor { get; set; }
        public string Text { get; set; }
        public DateTime CreateDate { get; set; }

        public Comment()
        {
            Id = _nextId++;
        }

    }
}
