using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace FaceBookApp.Logic
{
    public class AppSettings
    {
        public bool RememberUser { get; set; }

        public Point LastWindowsLocation { get; set; }

        public string LastAccessToken { get; set; }

        private AppSettings()
        {
            LastWindowsLocation = new Point(400, 200);
            RememberUser = false;
            LastAccessToken = null;
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings appSettingsFromFile = new AppSettings();
            if (File.Exists(@"AppSettings.xml"))
            {
                using (Stream stream = new FileStream(@"AppSettings.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    appSettingsFromFile = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return appSettingsFromFile;
        }

        public void SaveToFile()
        {
            using (Stream stream = new FileStream(@"AppSettings.xml", FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}