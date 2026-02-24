namespace InterfaceDemo
{
    public class Logger
    {
        /// <summary>
        /// Loggen von Message in der Datenbank
        /// </summary>
        /// <param name="message"></param>
        public virtual void Log(string message)
        {
            Console.WriteLine("Message wird in Datenbank gespeichrt");
        }

        /// <summary>
        /// Üebrmittlung von Loggs an WebServiece
        /// </summary>
        public virtual void TransferLog()
        {
            Console.WriteLine("Loggs werden an WebServiece übermittelt");
        }
    }
}
