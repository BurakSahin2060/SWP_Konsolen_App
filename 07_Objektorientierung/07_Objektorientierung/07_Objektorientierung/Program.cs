using System;
using _07_Objektorientierung;

class Program
{
    static void Main()
    {
        Tierheim tierheim = new Tierheim();

        Cat cat1 = new Cat("Kitty", new DateTime(2008, 1, 18), "black");
        Cat cat2 = new Cat("Tom", new DateTime(2007, 11, 11), "orange");
        Cat cat3 = new Cat("Jerry", new DateTime(2006, 12, 12), "gray");

        tierheim.AddCat(cat1);
        tierheim.AddCat(cat2);
        tierheim.AddCat(cat3);

        Console.WriteLine($"Anzahl der Katzen im Tierheim: {tierheim.CatCount}");
        tierheim.ShowAllCats();

        Console.ReadLine();
    }
}
