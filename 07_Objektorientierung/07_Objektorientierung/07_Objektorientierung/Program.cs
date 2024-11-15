// Instanz der Klasse Cat
//Cat myCat = new Cat(); // erstellt eine Instanz der Klasse Cat und weißt sie der Variable mit dem Namen myCat zu
//myCat.Color = "black";
//Console.WriteLine("The color of my Cat is " + myCat.Color);

//Cat myCat = new Cat(new DateTime(2008, 01, 18));
//myCat.Color = "black";
//Console.WriteLine("The color of my Cat is " + myCat.Color);
//Console.WriteLine("The age of my Cat is " + myCat.Age + " years.");

using System;
using _07_Objektorientierung;

class Program
{
    static void Main()
    {
        Tierheim tierheim = new Tierheim();

        Cat cat1 = new Cat(new DateTime(2008, 1, 18)) { Color = "black" };
        Cat cat2 = new Cat(new DateTime(2007, 11, 11)) { Color = "orange" };
        Cat cat3 = new Cat(new DateTime(2000, 12, 12)) { Color = "gray" };

        tierheim.AddCat(cat1);
        tierheim.AddCat(cat2);
        tierheim.AddCat(cat3);

        Console.WriteLine($"Anzahl der Katzen im Tierheim: {tierheim.CatCount}");

        tierheim.ShowAllCats();

        Console.ReadLine();
    }
}

