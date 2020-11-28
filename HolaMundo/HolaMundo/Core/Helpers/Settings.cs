using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace HolaMundo.Core.Helpers
{
    public static class Settings
    {
        public static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        public static string SecurityToken
        {
            get
            {
                return AppSettings.GetValueOrDefault("Token", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("Token", value);
            }
        }

        public static bool ServiceError
        {
            get
            {
                return AppSettings.GetValueOrDefault("ServiceError", false);
            }
            set
            {
                AppSettings.AddOrUpdateValue("ServiceError", value);
            }
        }
    }
}
