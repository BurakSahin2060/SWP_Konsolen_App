using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _08_Tierheim
{
    public class Cat : Animal
    {
        public string? Color { get; set; }
        public Cat(string name, string color, DateTime birthdate) : base(name, birthdate)
        {
            Color = color;
            Beine = 4;
        }
        public override void GibTypischenLautVonDir()
        {
            Console.WriteLine($"{Name} sagt: Meowwww");
        }
    }
}
