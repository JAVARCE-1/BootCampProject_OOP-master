﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Ticket_OOP.Modelos
{
    public class Developer :Persona
    {
        private static int _nextId = 1;
        public int Id { get; private set; }
        public string Role { get; set; }
        public string Seniority { get; set; }
        public List<Ticket> Ticket { get; set; } = new List<Ticket>();



        public Developer()
        {
            Id = _nextId++;
        }

    }
}
