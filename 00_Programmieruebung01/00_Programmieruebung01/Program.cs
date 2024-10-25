// Schreiben Sie eine Konsolenapplikation, welche eine Eingabe einliest und prüft, ob die Eingabe eine ganze Zahl ist. 
// Wenn die Eingabe eine Ganze Zahl ist soll eine Abfrage kommen die folgendermaßen ausschaut:
// Sie haben eine ganze Zahl eingegeben, welche mathematische Operation möchten Sie darauf ausführen?
// 1) Addition
// 2) Multiplikation
// 3) Division
// 4) Fakultät
// 5) Wurzelziehen
// Je nach Eingabe soll dann noch eine zweite Zahl eingelesen werden um die ausgewählte Operation durchzuführen 
// und das Resultat in der Konsole ausgegeben werden.

// Falls keine Ganzzahl eingegeben wurde soll folgende Abfrage kommen:
// Sie haben eine Zeichenkette eingeben. Was wollen Sie damit machen?
// 1) Alle Selbstlauge (a,e,i,o,u) entfernen
// 2) Die Zeichenkette "umdrehen" (aus "Hallo" wird dann z.B. "ollH")
// 3) Die Anzahl an Zeichen ausgeben
// Je nach Eingabe soll die entsprechende neue Zeichenkette oder ein Zahl in der Konsole ausgegeben werden.

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Bitte geben Sie eine ganze Zahl oder eine Zeichenkette ein (oder 'Beenden' zum Beenden): ");
            string input = Console.ReadLine();

            if (input.Equals("Beenden", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Programm wird beendet.");
                break;
            }

            if (int.TryParse(input, out int zahl))
            {
                // Falls eine ganze Zahl --> mathematische Operation
                MathematischeOperationen(zahl);
            }
            else
            {
                // Falls eine Zeichenkette --> Zeichenkettenoperation
                ZeichenkettenOperationen(input);
            }
        }
    }

    static void MathematischeOperationen(int zahl)
    {
        while (true)
        {
            Console.WriteLine("\nWählen Sie eine mathematische Operation:");
            Console.WriteLine("1... Addieren");
            Console.WriteLine("2... Multiplizieren");
            Console.WriteLine("3... Dividieren");
            Console.WriteLine("4... Fakultaet");
            Console.WriteLine("5... Wurzelziehen");
            Console.WriteLine("Geben Sie 'Zurück' ein, um zur Hauptauswahl zurückzukehren.");

            string operationInput = Console.ReadLine();
            if (operationInput.Equals("Zurück", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            int zahl2;
            switch (operationInput)
            {
                case "1": // Addieren
                    (zahl, zahl2) = ReadInTwoNumbers();
                    Console.WriteLine($"{zahl} + {zahl2} = {zahl + zahl2}");
                    break;

                case "2": // Multiplizieren
                    (zahl, zahl2) = ReadInTwoNumbers();
                    Console.WriteLine($"{zahl} * {zahl2} = {zahl * zahl2}");
                    break;

                case "3": // Dividieren
                    (zahl, zahl2) = ReadInTwoNumbers();
                    if (zahl2 != 0)
                    {
                        Console.WriteLine($"{zahl} / {zahl2} = {zahl / (double)zahl2}");
                    }
                    else
                    {
                        Console.WriteLine("Division durch Null ist nicht erlaubt!!!");
                    }
                    break;

                case "4": // Fakultaet
                    if (zahl >= 0)
                    {
                        Console.WriteLine($"Die Fakultaet von {zahl} ist {BerechneFakultaet(zahl)}");
                    }
                    else
                    {
                        Console.WriteLine("Fakultaet ist nur für nicht-negative Zahlen definiert!!!");
                    }
                    break;

                case "5": // Wurzelziehen
                    if (zahl >= 0)
                    {
                        Console.WriteLine($"Die Wurzel von {zahl} ist {Math.Sqrt(zahl)}");
                    }
                    else
                    {
                        Console.WriteLine("Wurzelziehen für negative Zahlen ist nicht definiert!!!");
                    }
                    break;

                default:
                    Console.WriteLine("Ungültige Auswahl!!!");
                    break;
            }
        }
    }

    static void ZeichenkettenOperationen(string text)
    {
        while (true)
        {
            Console.WriteLine("Sie haben eine Zeichenkette eingegeben. Was wollen Sie damit machen?");
            Console.WriteLine("1... Alle Selbstlaute (a, e, i, o, u) entfernen");
            Console.WriteLine("2... Die Zeichenkette 'umdrehen'");
            Console.WriteLine("3... Die Anzahl der Zeichen ausgeben");
            Console.WriteLine("Geben Sie 'Zurück' ein, um zur Hauptauswahl zurückzukehren.");

            string operationInput = Console.ReadLine();
            if (operationInput.Equals("Zurück", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            switch (operationInput)
            {
                case "1": // Selbstlaute entfernen
                    string result = new string(text.Where(c => !"aeiouAEIOU".Contains(c)).ToArray());
                    Console.WriteLine($"Ergebnis: {result}");
                    break;

                case "2": // Zeichenkette umdrehen
                    char[] charArray = text.ToCharArray();
                    Array.Reverse(charArray);
                    Console.WriteLine($"Ergebnis: {new string(charArray)}");
                    break;

                case "3": // Anzahl der Zeichen ausgeben
                    Console.WriteLine($"Anzahl der Zeichen: {text.Length}");
                    break;

                default:
                    Console.WriteLine("Ungültige Auswahl.");
                    break;
            }
        }
    }

    static (int, int) ReadInTwoNumbers()
    {
        Console.WriteLine("Bitte geben Sie die erste Zahl ein:");
        int zahl1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Bitte geben Sie die zweite Zahl ein:");
        int zahl2 = int.Parse(Console.ReadLine());

        return (zahl1, zahl2);
    }

    static long BerechneFakultaet(int zahl)
    {
        long ergebnis = 1;
        for (int i = 1; i <= zahl; i++)
        {
            ergebnis *= i;
        }
        return ergebnis;
    }
}
