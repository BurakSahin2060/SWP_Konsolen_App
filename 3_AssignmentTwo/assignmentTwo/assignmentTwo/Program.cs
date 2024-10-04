//Erweitern Sie ihre Konsolenanwendung. sodass sie eine natürliche Zahl einlesen können. 
//Ihr Programm soll dann die Eingabe in einen Integer konvertieren. 

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
            // überprüft ob die eingabe eine natürliche zahl ist
            if (int.TryParse(input, out int number) && number >= 0)
            {
                Console.WriteLine("Eingegebene natürliche Zahl: " + number);
            }
            else
            {
                Console.WriteLine("Bitte geben Sie eine gültige natürliche Zahl ein.");
            }
        }
    }
}
