
using InterfaceDemo;

namespace LapVorbereitungApp1.Models
{
    internal class LogDb : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Message wird in Datenbank gespeichrt");
        }

        public void TransferLog()
        {
            Console.WriteLine("Loggs werden an WebServiece übermittelt");
        }
    }
}
