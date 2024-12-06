using System;
using _07_Objektorientierung;

bool besuch = true;
Tierheim tierheim = new Tierheim();
Animal lastAnimal = null;

void StartTierConsole()
{
    while (besuch)
    {
        Console.WriteLine("Willst du ein Tier hinzufügen (yes/no)?");
        string userInput = Console.ReadLine()?.ToLower();

        if (userInput == "yes")
        {
            Console.WriteLine("Was für ein Tier möchtest du hinzufügen?\n1. Katze\n2. Hund");
            if (int.TryParse(Console.ReadLine(), out int tierArt))
            {
                switch (tierArt)
                {
                    case 1:
                        AddCat();
                        break;
                    case 2:
                        AddDog();
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe. Bitte gib eine 1 oder 2 ein.");
                        break;
                }

                ShowNextActions();
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl ein.");
            }
        }
        else if (userInput == "no")
        {
            besuch = false;
        }
        else
        {
            Console.WriteLine("Das ist keine gültige Eingabe. Bitte antworte mit 'yes' oder 'no'.");
        }
    }
}

void AddCat()
{
    Console.WriteLine("Gib das Geburtsdatum der Katze ein (z. B. 01.01.2020):");
    if (DateTime.TryParse(Console.ReadLine(), out DateTime geburtsdatum))
    {
        Console.WriteLine("Welche Farbe hat die Katze?");
        string farbe = Console.ReadLine();

        Console.WriteLine("Wie heißt die Katze?");
        string name = Console.ReadLine();

        Cat neueKatze = new Cat(geburtsdatum, farbe, name);
        tierheim.AddAnimal(neueKatze);
        lastAnimal = neueKatze;

        Console.WriteLine("Katze hinzugefügt. Hier ist die aktuelle Liste aller Tiere:");
        tierheim.ShowAnimals();
    }
    else
    {
        Console.WriteLine("Ungültiges Datum. Versuche es erneut.");
    }
}

void AddDog()
{
    Console.WriteLine("Gib das Geburtsdatum des Hundes ein (z. B. 01.01.2020):");
    if (DateTime.TryParse(Console.ReadLine(), out DateTime geburtsdatum))
    {
        Console.WriteLine("Welche Farbe hat der Hund?");
        string farbe = Console.ReadLine();

        Console.WriteLine("Wie heißt der Hund?");
        string name = Console.ReadLine();

        Dog neuerHund = new Dog(geburtsdatum, farbe, name);
        tierheim.AddAnimal(neuerHund);
        lastAnimal = neuerHund;

        Console.WriteLine("Hund hinzugefügt. Hier ist die aktuelle Liste aller Tiere:");
        tierheim.ShowAnimals();
    }
    else
    {
        Console.WriteLine("Ungültiges Datum. Versuche es erneut.");
    }
}

void ShowNextActions()
{
    Console.WriteLine("Was willst du nun tun?\n1. Ein weiteres Tier hinzufügen\n2. Geräusch vom letzten Tier ausgeben\n3. Beenden");
    if (int.TryParse(Console.ReadLine(), out int action))
    {
        switch (action)
        {
            case 1:
                break; // Bleibt in der Schleife von StartTierConsole.
            case 2:
                if (lastAnimal != null)
                {
                    lastAnimal.gibTypischenLautVonDir();
                }
                else
                {
                    Console.WriteLine("Es wurde noch kein Tier hinzugefügt.");
                }
                break;
            case 3:
                besuch = false;
                break;
            default:
                Console.WriteLine("Ungültige Auswahl. Versuche es erneut.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Ungültige Eingabe. Versuche es erneut.");
    }
}

StartTierConsole();