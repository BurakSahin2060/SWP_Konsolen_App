using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _07_Objektorientierung
{
    class Cat
    {
        private string _Color;
        private DateTime _BirthDate;

        public string Color
        {
            get { return _Color; }
            set
            {
                if (_Color == value) return;
                _Color = value;
            }
        }

        public int Age
        {
            get
            {
                var today = DateTime.Today;
                int age = today.Year - _BirthDate.Year;
                if (_BirthDate.Date > today.AddYears(-age)) age--;
                return age;
            }
        }

        public Cat(DateTime birthdate)
        {
            _BirthDate = birthdate;
        }
    }

    class Tierheim
    {
        private List<Cat> _cats;
        public Tierheim()
        {
            _cats = new List<Cat>();
        }

        public void AddCat(Cat cat)
        {
            _cats.Add(cat);
        }

        public void RemoveCat(Cat cat)
        {
            _cats.Remove(cat);
        }

        public void ShowAllCats()
        {
            Console.WriteLine("Katzen im Tierheim:");
            foreach (var cat in _cats)
            {
                Console.WriteLine($"Farbe: {cat.Color}, Alter: {cat.Age} Jahre");
            }
        }

        public int CatCount
        {
            get { return _cats.Count; }
        }
    }
}
