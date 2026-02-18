using LapVorbereitungApp1.Models;

namespace LapVorbereitungApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Unterricht_17022026();
        }

        private static void Unterricht_17022026()
        {
            // Prozedurall

            var auto1Marke = "Suzuki";
            var auto1Modell = "Swift";
            var auto1KmStand = 12000;

            var auto2Marke = "Opel";
            var auto2Modell = "Corsa";
            var auto2KmStand = 30000;

            //Console.WriteLine(auto1Marke);
            //Console.WriteLine(auto2Marke);

            //
            // Referenz-Datentypen: ? ist eine Markierug (Wert darf null sein)
            string? str = null; // 
            Fahrzeug? fzg = null; // 

            // Wert - Datentypen:
            int? zahl = null; // Mit ? mache ich die Variable nullfähig
            int zahl2;

            char ch1 = 'a';
            char ch2 = 'B';

            int erg = ch1 + ch1 + ch2;

            bool v;

            //

            //var fzgw = new Fahrzeug();

            //var fzg2 = new Fahrzeug("Opel", "XXX");


            //var fzg3 = new Auto { Marke = auto1Marke, Modell = "ddd"; }
            ////

            //var auto = new Auto();


            // REFERNZDATENTYPEN (Objekte, String)

            // Erzuegt ein neues Objekt im HEAP
            // Die Variable a1 liegt als lokale Variable im STACK
            // und speichert nur die Referenz (also die Adresse) 
            // und nicht das Objekt selbst
            var a1 = new Auto() { Marke = "Audi" }; // Heap: 1b

            // Hier wird kein neues Objekt erzeugt.
            // Es wird nur die Adresse kopiert
            // a2 speichert die Adresse von a1
            // Wichtig: a2 hängt NICHT an a1
            var a2 = a1;

            // Es wird ein NEUES Objekt im Heap erzeugt.
            // Dieses bekommt (fiktiv) die Adresse 2b.
            // Danach wird nur die Variable a1 überschrieben.
            // Das bedeutet:
            // Der gespeicherte Referenzwert in a1 wird ersetzt.
            // a2  wird dabei überhaupt nicht verändert,
            // weil a2  eine eigene Variable mit einem eigenen
            // gespeicherten Referenzwert ist.
            //
            // Viele glauben hier fälschlicherweise,
            // dass a2  automatisch "mitwandert".
            // Das stimmt nicht.
            // Zuweisung bedeutet nur: Wert kopieren.
            // Es entsteht keine dauerhafte Verbindung zwischen a2 und a1.
            a1 = new Auto() { Marke = "VW" }; // Heap: 2b

            Console.WriteLine(a2.Marke);


            // WERTEDATENTYPEN (structs, alle Zahlen, boolean, chars)

            // Erzuegt ein neues Objekt im STACK
            // Die Variable f1 liegt im STACK
            // und speichert dort ihren Wert 
            var f1 = new Fahrrad() { Marke = "BMW" };
            var f2 = f1;

            f1 = new Fahrrad() { Marke = "KTM" };
        }
    }
}
