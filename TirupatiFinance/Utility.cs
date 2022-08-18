using log4net;
using log4net.Config;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;

namespace TirupatiFinance
{
    public static class Utility
    {
        static Utility()
        {
            if (!Directory.Exists("Logs"))
            {
                Directory.CreateDirectory("Logs");
            }
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

        public static bool GenerateBackup()
        {
            try
            {
                if (!Directory.Exists("Backup"))
                {
                    DirectoryInfo directory = Directory.CreateDirectory("Backup");
                    DirectorySecurity security = directory.GetAccessControl();
                    security.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
                    directory.SetAccessControl(security);
                }

                string databaseName = Constants.DatabaseName;
                Server server = new Server(new ServerConnection());
                Backup backup = new Backup();
                backup.Action = BackupActionType.Database;
                backup.Database = databaseName;
                string path = System.Windows.Forms.Application.StartupPath + "\\Backup\\";

                BackupDeviceItem backupDevice = new BackupDeviceItem(path + databaseName + "_" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".bak", DeviceType.File);
                backup.Devices.Add(backupDevice);
                backup.Incremental = false;
                backup.SqlBackup(server);

                return true;
            }
            catch (Exception ex)
            {
                Utility.LogError(ex);
                return false;
            }
        }

        public static void LogError(Exception ex) {
            log.Error("Error Message : " + ex.Message + Environment.NewLine + "Stace Trace : " + ex.StackTrace);
        }
    }
}
