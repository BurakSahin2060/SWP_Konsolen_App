// Programmieraufgabe 6:
// Erweitern Sie ihre Konsolenapplikation in der Art, dass zuerst eine mathematische Operation abgefragt wird:
// Geben Sie die Entsprechende Nummer für die Auswahl einer mathematischen Operation an:
// 1... Multiplizieren
// 2... Dividieren
// 3... Addieren
// 4... Potenzieren
// 5... Wurzelziehen
// 6... Fakultät
// 7... Invertieren
// Je nach Auswahl soll im Anschluss entweder eine oder zwei Ganzzahlen eingelesen 
// und die entsprechende mathematische Operation ausgeführt werden.

using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            // Auswahl der mathematischen Operation
            Console.WriteLine("Wählen Sie eine mathematische Operation:");
            Console.WriteLine("1... Multiplizieren");
            Console.WriteLine("2... Dividieren");
            Console.WriteLine("3... Addieren");
            Console.WriteLine("4... Potenzieren");
            Console.WriteLine("5... Wurzelziehen");
            Console.WriteLine("6... Fakultät");
            Console.WriteLine("7... Invertieren");
            Console.WriteLine("Geben Sie 'Beenden' ein, um das Programm zu beenden.");

            string operationInput = Console.ReadLine();
            if (operationInput.Equals("Beenden", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Programm wird beendet.");
                break;
            }
            int zahl1, zahl2;
            switch (operationInput)
            {
                case "1": // Multiplizieren
                    (zahl1, zahl2) = ReadInTwoNumbers();
                    Console.WriteLine($"{zahl1} * {zahl2} = {zahl1 * zahl2}");
                    break;

                case "2": // Dividieren
                    (zahl1, zahl2) = ReadInTwoNumbers();
                    if (zahl2 != 0)
                    {
                        Console.WriteLine($"{zahl1} / {zahl2} = {zahl1 / (double)zahl2}");
                    }
                    else
                    {
                        Console.WriteLine("Division durch Null ist nicht erlaubt.");
                    }
                    break;

                case "3": // Addieren
                    (zahl1, zahl2) = ReadInTwoNumbers();
                    Console.WriteLine($"{zahl1} + {zahl2} = {zahl1 + zahl2}");
                    break;

                case "4": // Potenzieren
                    (zahl1, zahl2) = ReadInTwoNumbers();
                    Console.WriteLine($"{zahl1} ^ {zahl2} = {Math.Pow(zahl1, zahl2)}");
                    break;

                case "5": // Wurzelziehen
                    Console.WriteLine("Bitte geben Sie eine Zahl ein:");
                    int wurzelZahl = int.Parse(Console.ReadLine());
                    if (wurzelZahl >= 0)
                    {
                        Console.WriteLine($"Die Wurzel von {wurzelZahl} ist {Math.Sqrt(wurzelZahl)}");
                    }
                    else
                    {
                        Console.WriteLine("Wurzelziehen für negative Zahlen ist nicht definiert.");
                    }
                    break;

                case "6": // Fakultät
                    Console.WriteLine("Bitte geben Sie eine natürliche Zahl ein:");
                    int fakultaetZahl = int.Parse(Console.ReadLine());
                    if (fakultaetZahl >= 0)
                    {
                        Console.WriteLine($"Die Fakultät von {fakultaetZahl} ist {BerechneFakultaet(fakultaetZahl)}");
                    }
                    else
                    {
                        Console.WriteLine("Fakultät ist nur für nicht-negative Zahlen definiert.");
                    }
                    break;

                case "7": // Invertieren
                    Console.WriteLine("Bitte geben Sie eine Zahl ein:");
                    int invertZahl = int.Parse(Console.ReadLine());
                    if (invertZahl != 0)
                    {
                        Console.WriteLine($"Das Inverse von {invertZahl} ist {1.0 / invertZahl}");
                    }
                    else
                    {
                        Console.WriteLine("Das Inverse von Null ist nicht definiert.");
                    }
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
            ergebnis *= i;
        return ergebnis;
    }
}
