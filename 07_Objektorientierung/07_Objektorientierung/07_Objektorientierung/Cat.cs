using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _07_Objektorientierung
{
    class Cat : Animal
    {
        public Cat(DateTime birthDate, string color = "Nicht Verfügbar", string name = "nicht Verfügbar") : base(name, birthDate, color, 4, "Katze")
        {
        }
        public override string ToString()
        {
            return $"Name: {Name}, Farbe: {Color}, Alter: {Age}, Beine: {Beine}";
        }
        public override void gibTypischenLautVonDir()
        {
            Console.WriteLine("Meowwwwwww!");
        }
    }
}