using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Objektorientierung
{
    class Animal : Lebewesen
    {
        public string Name { get; set; }
        public Animal(string name, DateTime birthDate) : base(birthDate)
            public Animal(string name, DateTime birthDate, string color) : base(birthDate, color, name)
        {

            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
