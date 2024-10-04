//Erweitern Sie ihre Konsolenanwendung in der Art, dass nach dem Einlesen der Natürlichen Zahl eine Abfrage erscheint,
//in der Sie eine Mathematische Operation auswählen können... Dies kann zum Beispiel so ausschauen:
//Geben Sie eine Zahl zwischen 1 und 3 ein um eine Mathematische Operation auszuwählen:
//1) Quadrat
//2) Wurzel
//3) Fakultät

using System;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Bitte eine Eingabe tätigen (oder 'Beenden' zum Beenden):");
            string input = Console.ReadLine();

            if (input.Equals("Beenden", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Programm wird beendet.");
                break;
            }

            if (int.TryParse(input, out int intValue) && intValue >= 0)
            {
                Console.WriteLine($"Eingegebener Datentyp: Integer, Wert: {intValue}");

                Console.WriteLine("Wählen Sie eine Operation: 1) Quadrat, 2) Wurzel, 3) Fakultät");
                string operationInput = Console.ReadLine();

                switch (operationInput)
                {
                    case "1":
                        Console.WriteLine($"Das Quadrat von {intValue} ist {intValue * intValue}");
                        break;
                    case "2":
                        Console.WriteLine($"Die Wurzel von {intValue} ist {Math.Sqrt(intValue)}");
                        break;
                    case "3":
                        Console.WriteLine($"Die Fakultät von {intValue} ist {BerechneFakultaet(intValue)}");
                        break;
                    default:
                        Console.WriteLine("Ungültige Auswahl.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Bitte geben Sie eine gültige natürliche Zahl ein.");
            }
        }
    }
    static long BerechneFakultaet(int zahl)
    {
        long ergebnis = 1;
        for (int i = 1; i <= zahl; i++)
            ergebnis *= i;
        return ergebnis;
    }
}
