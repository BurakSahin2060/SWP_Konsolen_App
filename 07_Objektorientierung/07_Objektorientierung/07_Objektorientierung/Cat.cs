using _07_Objektorientierung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _07_Objektorientierung
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