﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Objektorientierung
{
    class Lebewesen
    {
        public DateTime _BirthDate { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get { return (DateTime.Now.Year - BirthDate.Year); } }
        public Lebewesen(DateTime birthDate)
            public Lebewesen(DateTime birthDate, string color, string name)
        {
            _BirthDate = birthDate;
            Color = color;
            BirthDate = birthDate;
            Name = name;
        }
    }
}
