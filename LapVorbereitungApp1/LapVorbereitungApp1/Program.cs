using InterfaceDemo;
using LapVorbereitungApp1.Models;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Xml.Linq;

namespace LapVorbereitungApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Unterricht_17022026();
            Unterricht_24022026();
            Unterricht_03032026();
        }

        private static void Unterricht_03032026()
        {
            // Ein Array ist ein zusammenhängender "Speicherblock",
            // in dem alle Elemente direkt hintereinander liegen.

            // Beispiel mit Werte-Datentyp
            int[] zahlen = new int[5];
            zahlen[0] = 6; // fiktive Adresse = 1000
            zahlen[1] = 23;
            zahlen[2] = 98;
            zahlen[3] = 55; // 1012
            zahlen[4] = 66;

            var zahl = zahlen[3];

            // Wo ist im Speicher zahlen[3]?
            // Formel:
            //      Adresse = Startadresse + (index * GrößeDesAktulleAbzufragendenArrayElements)
            //      Adresse von zahlen[3] = 1000 + (3 * 4) 


            // es wird ein Array mit 0 Plätzen angelegt
            // (s.g dynamisches Array)
            // List<T> = verwaltetes Array

            // Beispiel mit Referenz-Datentyp
            string[] woerter = new string[5];
            woerter[0] = "dddd"; // fiktive Adresse = 1000
            woerter[1] = "eeeee"; ;
            woerter[2] = "44"; ;
            woerter[3] = "ddd"; ; // 1024
            woerter[4] = "dddd";

            var w = woerter[3];

            // Wo ist im Speicher woerter[3]?
            // Formel:
            //      Adresse = Startadresse + (index * GrößeDesAktulleAbzufragendenArrayElements)
            //      Adresse von zahlen[3] = 1000 + (3 * 8) 8 Byte wird reserviert für die Ablage eines Verweises


            // es wird ein Array mit 0 Plätzen angelegt
            // (s.g dynamisches Array)
            // List<T> = verwaltetes Array

            List<int> zahlenList = new List<int>();


            foreach (var z in zahlen)
            {
                // Speicherung in z macht es langsamer

            }

            // Antipattern, weil wie foreach
            for (int i = 0; i < zahlenList.Count; i++)
            {
                // Speicherung in z macht es langsamer
                var z = zahlenList[i];
            }

            // Gutes Pattern
            for (int i = 0; i < zahlenList.Count; i++)
            {
                // Abruf mit Index immer schnell
                zahlenList[i] = i;
                zahlenList[i] =+ zahlenList[i];
            }

            //--------------------------------------------------
            // Verkette Liste
            LinkedList<int> list = new LinkedList<int>();

            // Suche nacht Elementen langsam
            // Hinzufügen, Löschen, Reverse.. sehr schell 


            // Statische Klassen
            var d = Config.WichigeSetingsAusDerDB;

            var m = new Motorrad();
            
            // Abruf von Static-Func (kein Instanz-Mitglied)
            var fr = Motorrad.CalcFussRaster();

            var dt = new DateTime();
            dt.Subtract(dt);

            var jetzt = DateTime.Now;


            var a = new Auto() { TürenAnzahl = 2 };

            ChangeAuto1(a);
            Console.WriteLine(a.TürenAnzahl);

            //var a2 = ChangeAuto2(a);


            void ChangeAuto1(Auto auto)
            {
                auto.TürenAnzahl = 4;
            }


            Auto ChangeAuto2(Auto auto)
            {
                auto.TürenAnzahl = 4;
                return auto;
            }


            var f = new Fahrrad() { Marke = "MTK" };

            ChangeFahrrad(f);
            Console.WriteLine(f.Marke);


            void ChangeFahrrad(Fahrrad auto)
            {
                auto.Marke = "KTM";
            }


        }


        private static void Unterricht_24022026()
        {
            //var auto = new Auto();
            //Console.WriteLine(auto.HatMehrAls4Räder);

            // Alte Schule
            // ❌ stark gekoppelt
            //Logger logger = new Logger();
            //logger.Log("Hallo, ein Fehler ist da");

            // 
            ILogger logger1;
            ILogger logger2;

            logger1 = new LogDb();
            logger1.Log("blablabal");

            logger2 = new LogFile();
            logger2.Log("blablabal");


            List<ILogger> list = new List<ILogger>();
            list.Add(logger1);
            list.Add(logger2);


            foreach (ILogger logger in list)
            {
                logger.Log("§");
            }

            var auto = new Auto();
            var fr = new Fahrrad();
            var mr = new Motorrad();

            var fzgList = new List<Fahrzeug>() { auto,  mr };

            foreach(var  f in fzgList)
            {
                Console.WriteLine(f.Farbe());
            }

            







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
