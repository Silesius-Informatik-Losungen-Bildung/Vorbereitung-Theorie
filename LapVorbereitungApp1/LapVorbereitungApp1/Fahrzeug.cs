namespace LapVorbereitungApp1
{
    public abstract class Fahrzeug
    {
        // Feld / Field
        protected string _marke;
        protected int _ps;

        public abstract string Farbe();

        public virtual int AnzahlRaeder()
        {
            return 4;
        }

        // Konstruktor
        public Fahrzeug()
        {
            _marke = "Fiat";
            Modell = "Punto";
            Ps = 1;
        }

        // Konstruktor
        public Fahrzeug(string marke, string? modell)
        {
            Marke = marke; 
            Modell = modell;
        }   

        // Property / Eigenschaft / Attribut 
        public string Marke
        {
            get { return _marke; }
            set { _marke = value; }
        }

        public int Ps
        {
            get { return _ps; }
            init { _ps = value; }
        }


        // Autoproperty
        public string? Modell { get; set; }

        // Methode = Verhalten
        public void Fahren()
        {
            Console.WriteLine("Fzg. fährt");
        }

        // Destruktor
        ~Fahrzeug()
        {

        }
    }
}
