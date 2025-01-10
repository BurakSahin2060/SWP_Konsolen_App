using _001_Programmieruebung2;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class SchuleTests
    {
        [Test]
        public void AnzahlSchueler_SollteRichtigeAnzahlZurueckgeben()
        {
            var schule = new Schule();
            schule.SchuelerListe.Add(new Schueler { Geschlecht = "Männlich", Geburtsdatum = new DateTime(2010, 5, 20), Schulklasse = "3bWi" });
            schule.SchuelerListe.Add(new Schueler { Geschlecht = "Weiblich", Geburtsdatum = new DateTime(2011, 8, 15), Schulklasse = "3bWi" });

            Assert.AreEqual(2, schule.AnzahlSchueler());
        }

        [Test]
        public void AnzahlSchuelerNachGeschlecht_SollteRichtigeWerteZurueckgeben()
        {
            var schule = new Schule();
            schule.SchuelerListe.Add(new Schueler { Geschlecht = "Männlich", Geburtsdatum = new DateTime(2010, 5, 20), Schulklasse = "3bWi" });
            schule.SchuelerListe.Add(new Schueler { Geschlecht = "Weiblich", Geburtsdatum = new DateTime(2011, 8, 15), Schulklasse = "3bWi" });

            var (maennlich, weiblich) = schule.AnzahlSchuelerNachGeschlecht();

            Assert.AreEqual(1, maennlich);
            Assert.AreEqual(1, weiblich);
        }

        [Test]
        public void Durchschnittsalter_SollteRichtigenWertBerechnen()
        {
            var schule = new Schule();
            schule.SchuelerListe.Add(new Schueler { Geschlecht = "Männlich", Geburtsdatum = DateTime.Today.AddYears(-10), Schulklasse = "3bWi" });
            schule.SchuelerListe.Add(new Schueler { Geschlecht = "Weiblich", Geburtsdatum = DateTime.Today.AddYears(-15), Schulklasse = "3bWi" });

            var durchschnittsalter = schule.Durchschnittsalter();

            Assert.AreEqual(12.5, durchschnittsalter, 0.1);
        }

        [Test]
        public void KannKlasseInRaumUnterrichtetWerden_SollteTrueZurueckgebenWennRaumGenugPlaetzeHat()
        {
            var schule = new Schule();
            schule.SchuelerListe.Add(new Schueler { Geschlecht = "Männlich", Geburtsdatum = new DateTime(2010, 5, 20), Schulklasse = "3bWi" });
            schule.SchuelerListe.Add(new Schueler { Geschlecht = "Weiblich", Geburtsdatum = new DateTime(2011, 8, 15), Schulklasse = "3bWi" });
            schule.KlassenraumListe.Add(new Klassenraum { RaumNummer = "101", AnzahlPlaetze = 20 });

            var ergebnis = schule.KannKlasseInRaumUnterrichtetWerden("3bWi", "101");

            Assert.IsTrue(ergebnis);
        }

        [Test]
        public void KannKlasseInRaumUnterrichtetWerden_SollteFalseZurueckgebenWennRaumZuKleinIst()
        {
            var schule = new Schule();
            schule.SchuelerListe.Add(new Schueler { Geschlecht = "Männlich", Geburtsdatum = new DateTime(2010, 5, 20), Schulklasse = "3bWi" });
            schule.SchuelerListe.Add(new Schueler { Geschlecht = "Weiblich", Geburtsdatum = new DateTime(2011, 8, 15), Schulklasse = "3bWi" });
            schule.KlassenraumListe.Add(new Klassenraum { RaumNummer = "101", AnzahlPlaetze = 1 });

            var ergebnis = schule.KannKlasseInRaumUnterrichtetWerden("3bWi", "101");

            Assert.IsFalse(ergebnis);
        }
    }
}