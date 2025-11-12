using System;

public class Kursiyer_Model
{
    public int ID { get; set; }
    public string TC_NO { get; set; }
    public string ADI { get; set; }
    public string SOYADI { get; set; }
    public DateTime? DOGUM_TARIHI { get; set; }
    public DateTime? KAYIT_TARIHI { get; set; } = DateTime.Now;
    public string KIM_BABA_ADI { get; set; }
    public string KIM_ANA_ADI { get; set; }
    public string GSM_1 { get; set; }
    public string EV_ADRESI { get; set; }
    public byte[] RESIM { get; set; }
    public string ADAY_NO { get; set; }
    public string GSM_2 { get; set; }
     public string  EV_TELEFON { get; set; }
    public string Tnk_Referans { get; set; }
    public string KIM_DOGUM_YERI { get; set; }
    public int ID_GRUP_KARTI { get; set; }      // Kursiyerin grup ID'si
    public string SERTIFIKA_SINIFI { get; set; }  // ComboBox’ta seçilen dönemi saklamak için
    public string SARI_NOTLAR { get; set; }    // Sarı notlar
    public String DONEM_ADI { get; set; }      // Kursiyerin dönem adı
    public int? ID_DONEM { get; set; }        // Kursiyerin dönem ID'si
    public string GRUP_KARTI { get; set; }
    public string ONCEKI_SINIFI { get; set; }
    public string MEVCUT_SINIFI { get; set; }
    public string YENI_SINIFI { get; set; }
    public string StifikaSinifi { get; set; }

    public string ONCE_SERT_SINIFI { get; set; }
   
    public int? ID_GRUP { get; set; }
    public string ID_KURSIYER { get; set; }
    public string OGR_BEL_VEREN_KURUM { get; set; }
    public string OGR_BEL_SAYISI { get; set; }
    public DateTime OGR_BEL_TARIHI { get; set; }

    public byte[] IMG_OGRNIM_BEL { get; set; } = null;
    public int ID_Kursiyer { get; set; }  // KURSIYER_EVRAK tablosundaki foreign key

    public string OgrBelgeVerenKurum { get; set; }
    public DateTime? OgrBelgeTarihi { get; set; }
    public string OgrBelgeSayisi { get; set; }
    public byte[] OgrBelgeResmi { get; set; }
   

}
