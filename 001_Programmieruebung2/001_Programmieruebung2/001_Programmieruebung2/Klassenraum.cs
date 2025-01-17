using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Programmieruebung2
{
    public class Klassenraum
    {
        public string RaumNummer { get; set; }
        public double Groesse { get; set; }
        public int AnzahlPlaetze { get; set; }
        public bool HatCynap { get; set; }
        public List<Schueler> SchuelerListe { get; set; } = new List<Schueler>();
    }
}
