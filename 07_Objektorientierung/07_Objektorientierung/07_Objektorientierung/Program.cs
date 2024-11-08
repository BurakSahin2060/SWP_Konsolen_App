// See https://aka.ms/new-console-template for more information
using _07_Objektorientierung;

Console.WriteLine("Hello, World!");

// Instanz der Klasse Cat
//Cat myCat = new Cat(); // erstellt eine Instanz der Klasse Cat und weißt sie der Variable mit dem Namen myCat zu
//myCat.Color = "black";
//Console.WriteLine("The color of my Cat is " + myCat.Color);

Cat myCat = new Cat(new DateTime(2008, 01, 18));
myCat.Color = "black";
Console.WriteLine("The color of my Cat is " + myCat.Color);
Console.WriteLine("The age of my Cat is " + myCat.Age + " years.");

