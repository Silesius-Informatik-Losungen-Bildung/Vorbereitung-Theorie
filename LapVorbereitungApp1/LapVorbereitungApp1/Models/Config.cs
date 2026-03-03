namespace LapVorbereitungApp1.Models
{
    internal static class Config
    {
        static Config()
        {
            WichigeSetingsAusDerDB = "WertAusD";
        }

        public static string WichigeSetingsAusDerDB
        {
            get; 
            set;
        }
    }
}
