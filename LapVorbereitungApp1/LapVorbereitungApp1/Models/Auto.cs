namespace LapVorbereitungApp1.Models
{
    public sealed class Auto : Fahrzeug
    {
        public Auto(string marke, string modell) : base(marke, modell)
        {

        }
        public Auto()
        {
            _marke = "XX";
        }

        public int TürenAnzahl { get; set; }

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
