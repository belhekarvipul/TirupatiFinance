using System.Configuration;
using System.Globalization;
using System.Resources;

namespace TirupatiFinance
{
    public static class Constants
    {
        public static string UserName = "";
        public static bool isSystemUser = false;

        public static string ApplicationName = ConfigurationManager.AppSettings["ApplicationName"].ToString();
        public static string DatabaseName = ConfigurationManager.AppSettings["DatabaseName"].ToString();

        public static string DefaultPassword = Utility.Encrypt("123", ApplicationName);


        public static ResourceManager resourceManager = new ResourceManager("TirupatiFinance.Resource.English", typeof(Login).Assembly);
        public static CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");

        public enum Language
        {
            English,
            Marathi,
            Hindi
        };

        public enum ReturnType
        {
            Daily,
            Weekly,
            Monyhly,
            Yearly
        };

        public enum Role
        {
            MasterAdmin = 1,
            Admin = 2,
            NonAdmin = 3
        };
    }
}
