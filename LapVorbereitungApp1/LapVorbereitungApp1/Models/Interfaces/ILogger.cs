namespace InterfaceDemo
{
    public interface ILogger
    {
        /// <summary>
        /// Loggen von Message auf ??
        /// </summary>
        /// <param name="message"></param>
        void Log(string message);
        
        /// <summary>
        /// Üebrmittlung von Loggs an ??
        /// </summary>
        void TransferLog();
    }
}
