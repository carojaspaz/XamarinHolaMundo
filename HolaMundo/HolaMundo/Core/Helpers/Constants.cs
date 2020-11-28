namespace HolaMundo.Core.Helpers
{
    public class Constants
    {
        public class ApiConstants
        {
#if DEBUG
            public static string urlBase = "http://18.216.29.21:3000/api/v1/";
#else
            public static string urlBase = "http://18.216.29.21:3000/api/v1/";
#endif
            public static int SetTimeOut = 60;
        }
    }
}
