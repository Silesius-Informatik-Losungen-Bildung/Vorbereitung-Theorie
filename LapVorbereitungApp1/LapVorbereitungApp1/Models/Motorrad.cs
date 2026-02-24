using LapVorbereitungApp1.Models.Interfaces;

namespace LapVorbereitungApp1.Models
{
    public sealed class Motorrad : Fahrzeug
    {
        public Motorrad(string marke, string modell) : base(marke, modell)
        {

        }
        public Motorrad()
        {
            _marke = "XX";
        }

        public int TürenAnzahl { get; set; }
        public bool HatMehrAls4Räder
        {
            get { 
                return true;
            }
        }

        public override string Farbe()
        {
            return "rot";
        }

        public override int AnzahlRaeder()
        {
            return base.AnzahlRaeder() + 2;
        }
    }
}
