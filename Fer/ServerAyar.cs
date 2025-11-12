using System.Xml.Serialization;

namespace Tarantula_MTSK.Models
{
    public class ServerAyar
    {
        public string Sunucu { get; set; }
        public string BaglantiTuru { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
        public string VeritabaniAdi { get; set; }

        [XmlIgnore] // Bu sayede XML'den deserialize edilmez
        public string ConnectionString { get; internal set; }

    }
}