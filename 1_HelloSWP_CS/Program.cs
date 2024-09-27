// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Bitte geben Sie eine Zeichenkette ein: ");

// Programmierauftrag 1 ((noch) keine Programmierübung == wird nicht bewertet)
// Schreiben sie eine C# Konsolenanwendung welche
// _ Eine Eingabe über die Tastatur einliest 
//  _ mit <Enter> soll die Eingabe "abgeschlossen" werden und der eingegebene String auf der Konsole ausgegeben werden
//  _ Bei Eingabe von "Beenden" soll das Programm beendet werden

using System;
class Program
{
    static void Main()
    {
        string input;
        while (true)
        {
            Console.WriteLine("Bitte eine Eingabe tätigen (oder 'Beenden' zum Beenden):");
            input = Console.ReadLine();
            if (input.Equals("Beenden", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Programm wird beendet.");
                break;
            }
            Console.WriteLine("Eingegebener Text: " + input);
        }
    }
}