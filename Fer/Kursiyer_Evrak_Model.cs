using System;

public class Kursiyer_Evrak_Model
{
    public int ID { get; set; }
    public int ID_Kursiyer { get; set; }

    public bool EkskOgrBel { get; set; }
    public bool EkskSaglik { get; set; }
    public bool EkskSavcilik { get; set; }
    public bool EkskSozlesme { get; set; }
    public bool EkskImza { get; set; }

    public string OgrBelgeTuru { get; set; }
    public string OgrBelgeVerenKurum { get; set; }
    public string OgrBelgeSayisi { get; set; }

    public byte[] ImgOgrBel { get; set; }
    public byte[] ImgSaglik { get; set; }
    public byte[] ImgSavcilik { get; set; }
    public byte[] ImgSozlesme { get; set; }
    public byte[] ImgImza { get; set; }
    public byte[] ImgSozlesme_on { get; set; }
    public byte[] ImgSozlesme_arka { get; set; }



    // Checklist Alanları (UI’da CheckBox)
    public bool EkskNufCuzFot { get; set; }
    public bool EkskFotograf { get; set; }
    
    public bool EkskSurucuBel { get; set; }
    public bool EkskMTSKSertifika { get; set; }
    public bool EkskMuracaat { get; set; }
   
    public bool EkskDiger1 { get; set; }
    public bool EkskDiger2 { get; set; }
    public bool EkskDiger3 { get; set; }
   
    public bool EkskWebCam { get; set; }
    public bool EkskFatura { get; set; }

     
   
    
    public DateTime? OgrBelgeTarihi { get; set; }
    

    // Görseller
    public byte[] ImgNufCuzOn { get; set; }
    public byte[] ImgNufCuzArka { get; set; }
    public byte[] ImgSurBelOn { get; set; }
    public byte[] ImgSurBelArka { get; set; }
   
    
   
    public byte[] ImgMTSKSertifika { get; set; }
    public byte[] ImgMuracaat { get; set; }
    public byte[] ImgSozlesmeOn { get; set; }
    public byte[] ImgSozlesmeArka { get; set; }
    public byte[] ImgDiger1 { get; set; }
    public byte[] ImgDiger2 { get; set; }
    public byte[] ImgDiger3 { get; set; }
  
    public byte[] ImgFatura { get; set; }

    // Fatura
    public string FaturaNo { get; set; }
    public DateTime? FaturaTarihi { get; set; }
    public decimal? FaturaTutar { get; set; }
}
