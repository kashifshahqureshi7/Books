using SchoolManegment.Debugging;

namespace SchoolManegment
{
    public class SchoolManegmentConsts
    {
        public const string LocalizationSourceName = "SchoolManegment";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "56b9a2711362481cae56b7dd2250f302";
    }
}
