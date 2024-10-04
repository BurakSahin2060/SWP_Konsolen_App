// Programmieraufgabe 3:
// Erweitern Sie ihre Konsolenanwendung in der Art, dass der Datentyp des eingegebenen Strings identifiziert und ausgegeben wird. 
// Das Programm soll für true/false bzw. Wahr/falsch den Datentyp Bool verwenden, für
// eine Kommazahl einen double (was ist der Unterschied zu einem Float?), für
// eine Ganzzahl den Typ Integer und für ein Datum einen Datumstyp
// Initialisieren sie nach identifizieren des Datentyps auch jeweils eine Variable mit dem entsprechenden Typ.

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
            // überprüfen auf bool
            if (bool.TryParse(input, out bool boolValue))
            {
                Console.WriteLine($"Eingegebener Datentyp: Bool, Wert: {boolValue}");
                bool myBool = boolValue;
            }
            // überprüfen auf Ganzzahl
            else if (int.TryParse(input, out int intValue))
            {
                Console.WriteLine($"Eingegebener Datentyp: Integer, Wert: {intValue}");
                int myInt = intValue;
            }
            // überprüfen auf Kommazahl
            else if (double.TryParse(input, out double doubleValue))
            {
                Console.WriteLine($"Eingegebener Datentyp: Double, Wert: {doubleValue}");
                double myDouble = doubleValue;
            }
            // überprüfen auf Datum
            else if (DateTime.TryParse(input, out DateTime dateValue))
            {
                Console.WriteLine($"Eingegebener Datentyp: DateTime, Wert: {dateValue}");
                DateTime myDateTime = dateValue;
            }
            else
            {
                Console.WriteLine("Unbekannter Datentyp. Bitte geben Sie eine gültige Eingabe ein.");
            }
        }
    }
}
