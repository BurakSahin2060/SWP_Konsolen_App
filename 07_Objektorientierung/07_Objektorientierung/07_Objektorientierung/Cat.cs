using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _07_Objektorientierung;

class Cat : Animal
{

    public string Color { get; set; }
    public int Age { get { return (DateTime.Now.Year - _BirthDate.Year); } }

    public Cat(DateTime birthDate, string color = "Nicht Verfügbar", string name = "nicht Verfügbar") : base(name, birthDate)

        public Cat(DateTime birthDate, string color = "Nicht Verfügbar", string name = "nicht Verfügbar") : base(name, birthDate, color)
    {
        Color = color;
    }
    public override string ToString()
    {
        return $"Name: {Name}, Farbe: {Color}, Alter: {Age}";
    }
}

class Tierheim
{
    private List<Cat> cats = new List<Cat>();

    public void AddCat(Cat cat)
    {
        cats.Add(cat);
    }

    public int CatCount
    {
        get { return cats.Count; }
    }

    public void ShowAllCats()
    {
        foreach (var cat in cats)
        {
            Console.WriteLine($"Name: {cat.Name}, Farbe: {cat.Color}, Alter: {cat.Age} Jahre");
        }
    }
}