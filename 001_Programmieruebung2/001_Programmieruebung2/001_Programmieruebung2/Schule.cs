using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Programmieruebung2
{
    public class Schule
    {
        public List<Schueler> SchuelerListe { get; set; } = new List<Schueler>();
        public List<Klassenraum> KlassenraumListe { get; set; } = new List<Klassenraum>();

        public int AnzahlSchueler()
        {
            return SchuelerListe.Count;
        }

        public (int maennlich, int weiblich) AnzahlSchuelerNachGeschlecht()
        {
            var maennlich = SchuelerListe.Count(s => s.Geschlecht == "Männlich");
            var weiblich = SchuelerListe.Count(s => s.Geschlecht == "Weiblich");
            return (maennlich, weiblich);
        }

        public int AnzahlKlassenraeume()
        {
            return KlassenraumListe.Count;
        }

        public double Durchschnittsalter()
        {
            if (!SchuelerListe.Any()) return 0;
            var heute = DateTime.Today;
            return SchuelerListe.Average(s => (heute - s.Geburtsdatum).TotalDays / 365);
        }

        public List<Klassenraum> RaeumeMitCynap()
        {
            return KlassenraumListe.Where(r => r.HatCynap).ToList();
        }

        public int AnzahlKlassen()
        {
            return SchuelerListe.Select(s => s.Schulklasse).Distinct().Count();
        }

        public Dictionary<string, int> KlassenMitSchuelerAnzahl()
        {
            return SchuelerListe
                .GroupBy(s => s.Schulklasse)
                .ToDictionary(g => g.Key, g => g.Count());
        }

        public double FrauenanteilInKlasse(string klasse)
        {
            var schuelerInKlasse = SchuelerListe.Where(s => s.Schulklasse == klasse).ToList();
            if (!schuelerInKlasse.Any()) return 0;

            var frauen = schuelerInKlasse.Count(s => s.Geschlecht == "Weiblich");
            return (double)frauen / schuelerInKlasse.Count * 100;
        }

        public bool KannKlasseInRaumUnterrichtetWerden(string klasse, string raumNummer)
        {
            var raum = KlassenraumListe.FirstOrDefault(r => r.RaumNummer == raumNummer);
            if (raum == null) return false;

            var anzahlSchueler = SchuelerListe.Count(s => s.Schulklasse == klasse);
            return anzahlSchueler <= raum.AnzahlPlaetze;
        }
    }
}
