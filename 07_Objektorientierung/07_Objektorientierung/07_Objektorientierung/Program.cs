using System;
using _07_Objektorientierung;

Tierheim tierheim = new Tierheim();
List<Animal> cat = new List<Animal>();

tierheim.AddAnimal(new Cat("Luna", "weiß", new DateTime(2020, 5, 15)));
tierheim.AddAnimal(new Cat("Milo", "grau", new DateTime(2018, 3, 10)));
tierheim.AddAnimal(new Cat("Tom", "schwarz", new DateTime(2019, 7, 25)));

tierheim.AddAnimal(new Dog("Burak", "braun", new DateTime(2017, 6, 5)));
tierheim.AddAnimal(new Dog("Fritz", "schwarz", new DateTime(2021, 1, 20)));


Console.WriteLine($"Gesamte Tieranzahl im Tierheim: {tierheim.GetAnimalCount()}");
Console.WriteLine($"Anzahl der Katzen im Tierheim: {tierheim.NumberOfCats()}");
Console.WriteLine($"Anzahl der Hunde im Tierheim: {tierheim.NumberOfDogs()}");



Console.WriteLine("\nTiere im Tierheim:");
foreach (var animal in tierheim.GetAllAnimals())
{
    Console.WriteLine($"Tier: Art = {animal.GetType().Name}, Name = {animal.Name}, Beine = {animal.Beine}");
}

Console.WriteLine("\nTypische Laute der Tiere:");
foreach (var animal in tierheim.GetAllAnimals())
{
    animal.GibTypischenLautVonDir();
}