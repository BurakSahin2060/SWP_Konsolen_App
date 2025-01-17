using System;

namespace _001_Programmieruebung2
{
    class Program
    {
        static void Main(string[] args)
        {
            var schule = new Schule();

            // Beispiele
            schule.SchuelerListe.Add(new Schueler { Geschlecht = "Männlich", Geburtsdatum = new DateTime(2008, 1, 18), Schulklasse = "3bWi" });
            schule.SchuelerListe.Add(new Schueler { Geschlecht = "Weiblich", Geburtsdatum = new DateTime(2011, 11, 11), Schulklasse = "3bWi" });
            schule.KlassenraumListe.Add(new Klassenraum { RaumNummer = "101", Groesse = 30.0, AnzahlPlaetze = 20, HatCynap = true });

            Console.WriteLine($"Anzahl Schüler: {schule.AnzahlSchueler()}");
            var geschlechter = schule.AnzahlSchuelerNachGeschlecht();
            Console.WriteLine($"Männlich: {geschlechter.maennlich}, Weiblich: {geschlechter.weiblich}");
            Console.WriteLine($"Anzahl Klassenräume: {schule.AnzahlKlassenraeume()}");
            Console.WriteLine($"Durchschnittsalter: {schule.Durchschnittsalter():F2} Jahre");
            Console.WriteLine($"Räume mit Cynap: {string.Join(", ", schule.RaeumeMitCynap().Select(r => r.RaumNummer))}");
        }
    }
}
