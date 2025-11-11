using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Tarantula_MTSK.Models;
using Tarantula_MTSK.Sayfalar;

namespace Tarantula_MTSK
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string xmlPath = @"C:\Mtsk\Tarantula_MTSK\Tarantula_MTSK\Tarantula_MTSK\Baglan.xml";
            var serverAyar = DeserializeServerAyar(xmlPath);

            if (serverAyar == null)
            {
                MessageBox.Show("Server ayarları yüklenemedi.");
                return;
            }

            // 🔹 Connection string runtime’da oluşturuluyor
            serverAyar.ConnectionString = serverAyar.BaglantiTuru?.ToLower() == "sql"
                ? $"Server={serverAyar.Sunucu};Database={serverAyar.VeritabaniAdi};User Id={serverAyar.KullaniciAdi};Password={serverAyar.Parola};"
                : $"Server={serverAyar.Sunucu};Database={serverAyar.VeritabaniAdi};Integrated Security=True;";

            // Ana_Menu formunu parametreli constructor ile başlat
            Application.Run(new Ana_Menu(serverAyar));
        }

        static ServerAyar DeserializeServerAyar(string xmlFilePath)
        {
            if (!File.Exists(xmlFilePath))
            {
                MessageBox.Show("XML dosyası bulunamadı.");
                return null;
            }

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ServerAyar));
                using (FileStream fs = new FileStream(xmlFilePath, FileMode.Open))
                {
                    return (ServerAyar)serializer.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Deseralizasyon hatası: {ex.Message}");
                return null;
            }
        }
    }
}
