using System.Configuration;
using System.Globalization;
using System.Resources;

namespace TirupatiFinance
{
    public static class Constants
    {
        public static string UserName = "";
        public static string ApplicationName = ConfigurationManager.AppSettings["ApplicationName"].ToString();
        public static bool isSystemUser = false;

        public static ResourceManager resourceManager = new ResourceManager("TirupatiFinance.Resource.English", typeof(Login).Assembly);
        public static CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");

        public enum Language
        {
            English,
            Marathi,
            Hindi
        };
    }
}
