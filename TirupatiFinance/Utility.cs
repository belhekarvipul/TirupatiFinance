using System.Security.Cryptography;
using System.Text;
using System.Globalization;
using System.Resources;
using log4net;
using log4net.Config;

namespace TirupatiFinance
{
    public static class Utility
    {
        static Utility() {
            XmlConfigurator.Configure();
        }
        
        public static readonly ILog log = LogManager.GetLogger(typeof(Utility));

        public static string Encrypt(string input, string key)
        {
            var inputBytes = Encoding.UTF8.GetBytes(input);
            var keyBytes = Encoding.UTF8.GetBytes(key);
            var hashedInputStringBuilder = new StringBuilder();

            using (HashAlgorithm hash = new SHA256Managed())
            {
                byte[] inputWithKeyBytes = new byte[inputBytes.Length + keyBytes.Length];
             
                for (int i = 0; i < inputBytes.Length; i++)
                    inputWithKeyBytes[i] = inputBytes[i];

                for (int i = 0; i < keyBytes.Length; i++)
                    inputWithKeyBytes[inputBytes.Length + i] = keyBytes[i];

                var hashedInputBytes = hash.ComputeHash(inputWithKeyBytes);

                foreach (var currentByte in hashedInputBytes)
                    hashedInputStringBuilder.Append(currentByte.ToString("X2"));

                return hashedInputStringBuilder.ToString();
            }
        }

        public static void SetLanguage(Constants.Language language)
        {
            switch (language)
            {
                case Constants.Language.English:
                    Constants.culture = CultureInfo.CreateSpecificCulture("en-US");
                    Constants.resourceManager = new ResourceManager("TirupatiFinance.Resource.English", typeof(Login).Assembly);
                    break;
                case Constants.Language.Marathi:
                    Constants.culture = CultureInfo.CreateSpecificCulture("mr-IN");
                    Constants.resourceManager = new ResourceManager("TirupatiFinance.Resource.Marathi", typeof(Login).Assembly);
                    break;
                case Constants.Language.Hindi:
                    Constants.culture = CultureInfo.CreateSpecificCulture("hi-IN");
                    Constants.resourceManager = new ResourceManager("TirupatiFinance.Resource.Hindi", typeof(Login).Assembly);
                    break;
                default:
                    Constants.culture = CultureInfo.CreateSpecificCulture("en-US");
                    Constants.resourceManager = new ResourceManager("TirupatiFinance.Resource.English", typeof(Login).Assembly);
                    break;
            }
        }
    }
}
