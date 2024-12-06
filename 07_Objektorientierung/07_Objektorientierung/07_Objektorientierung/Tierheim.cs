using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Objektorientierung
{
    class Tierheim
    {
        public List<Cat> tiere = new List<Cat>();

        public void AddAnimal(Cat cat)
        public List<Animal> tiere = new List<Animal>();
        public void AddAnimal(Animal animal)
        {
            tiere.Add(cat);
            Console.WriteLine($"\nEs wurde die neue Katze {cat} hinzugefügt!\n");
            tiere.Add(animal);
            Console.WriteLine($"\nEs wurde neues {animal.TierTyp} {animal} hinzugefügt!\n");
        }
        public void ShowAnimals()
        {
            int index = 1;
            foreach (var cat in tiere)
            {
                Console.WriteLine(cat);
            }
        }
    }
}
