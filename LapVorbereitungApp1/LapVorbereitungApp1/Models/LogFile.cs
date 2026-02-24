namespace InterfaceDemo
{
    internal class LogFile : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Message wird in Datei log.txt geloggt");
        }

        public void TransferLog()
        {
            Console.WriteLine("Alle Messagse werden in eine Temp-Verzeichnis üebrführt");
        }
    }
}
