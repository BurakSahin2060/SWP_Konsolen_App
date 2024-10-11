// Programmieraufgabe 5: (Arbeiten mit Strings)
// Schreiben Sie eine Konsolenanwendung die einen String einliest und die Anzahl an Selbstlauten (a,e,i,o,u)
// in dem String bestimmt und ausgibt.
 
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Bitte geben Sie einen Text ein:");
        string input = Console.ReadLine().ToLower();
 
        int vokalAnzahl = 0;
        foreach (char c in input)
        {
            if ("aeiou".Contains(c))
            {
                vokalAnzahl++;
            }
        }
 
        Console.WriteLine($"Die Anzahl der Selbstlaute (a, e, i, o, u) im Text beträgt: {vokalAnzahl}");
    }
}
 