using AcmeCorp.Debugging;

namespace AcmeCorp
{
    public class AcmeCorpConsts
    {
        public const string LocalizationSourceName = "AcmeCorp";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "25f9d1fe79384de195acf54ca9954307";
    }
}
