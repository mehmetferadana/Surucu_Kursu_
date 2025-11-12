using System;

namespace Tarantula_MTSK.Models
{
    public class KursiyerEvrak_Model
    {
        public int ID { get; set; }
        public int ID_Kursiyer { get; set; }

        /// <summary>
        /// /kullanılanlar
        /// </summary>

        public bool EkskOgrBel { get; set; }
        public bool EkskSaglik { get; set; }
        public bool EkskSavcilik { get; set; }
        public bool EkskSozlesme { get; set; }
        public bool EkskImza { get; set; }



        public DateTime? OgrBelgeTarihi { get; set; }
        public string OgrBelgeNo { get; set; } = string.Empty;
        public string OgrBelgeTuru { get; set; }
        public string OgrBelgeVerenKurum { get; set; }
        public string OgrBelgeSayisi { get; set; }

        public string SaglikBelverenKurum { get; set; }  
        public string SaglikBelgeNo { get; set; } 
       
        public string SaglikBelgeSayisi { get; set; }  
        public DateTime? SaglikBelgeTarihi { get; set; }

        public string SaglikBelgeVerenKurum { get; set; } 

        public string  SaglikBelReferans { get; set; }



        public string SavcilikBelgeVerenKurum { get; set; } = string.Empty;
        public string SavcilikBelgeNo { get; set; } = string.Empty;
        public DateTime? SavcilikBelgeTarihi { get; set; }


        public byte[] ImgOgrBel { get; set; }
        public byte[] ImgSaglik { get; set; }
        public byte[] ImgSavcilik { get; set; }
        public byte[] ImgSozlesme { get; set; }
        public byte[] ImgImza { get; set; }
        public DateTime Tarih { get; set; } = DateTime.MinValue;
        public byte[] ImgMTSKSertifika { get; set; }
        public byte[] ImgMuracaat { get; set; }
       
        public byte[] ImgSozlesme_On { get; set; }
        
        public byte[] ImgSozlesme_Arka { get; set; }
        public byte[] ImgDiger1 { get; set; }
        public byte[] ImgDiger2 { get; set; }
        public byte[] ImgDiger3 { get; set; }
        public DateTime? SozlesmeTarihi { get; set; }

        public byte[] ImgFatura { get; set; }


    }
}
