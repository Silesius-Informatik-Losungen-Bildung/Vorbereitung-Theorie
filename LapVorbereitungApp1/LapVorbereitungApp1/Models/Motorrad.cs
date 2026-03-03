using LapVorbereitungApp1.Models.Interfaces;

namespace LapVorbereitungApp1.Models
{
    public sealed class Motorrad : Fahrzeug
    {
        // Instanz-Variable
        private int _türenAnzahl;

        public Motorrad(string marke, string modell) : base(marke, modell)
        {

        }
        public Motorrad()
        {
            _marke = "XX";
        }

        public int TürenAnzahl
        {
            get
            {
                return _türenAnzahl;
            }
            set
            {
                _türenAnzahl = value;
            }
        }

        // Statisches Mitglied
        public static int CalcFussRaster()
        {
            return 12;
        }


        public bool HatMehrAls4Räder
        {
            get
            {
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
