using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Tarantula_MTSK.Models;

namespace Tarantula_MTSK.Services
{
    public class KursiyerService
    {
        private readonly string _connectionString;

        public KursiyerService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<int> AddKursiyerAsync(Kursiyer_Model model)
        {
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(@"
                INSERT INTO KURSIYER 
                (ADI, SOYADI, TC_NO, GSM_1, GSM_2, KIM_BABA_ADI, KIM_ANA_ADI, KIM_DOGUM_YERI,
                 EV_ADRESI, ADAY_NO, SARI_NOTLAR, DOGUM_TARIHI, KAYIT_TARIHI, RESIM, ID_GRUP_KARTI, SERTIFIKA_SINIFI, ONCE_SERT_SINIFI)
                VALUES 
                (@ADI, @SOYADI, @TC_NO, @GSM_1, @GSM_2, @KIM_BABA_ADI, @KIM_ANA_ADI, @KIM_DOGUM_YERI,
                 @EV_ADRESI, @ADAY_NO, @SARI_NOTLAR, @DOGUM_TARIHI, @KAYIT_TARIHI, @RESIM, @ID_GRUP_KARTI, @SERTIFIKA_SINIFI, @ONCE_SERT_SINIFI);
                SELECT SCOPE_IDENTITY();", conn))
            {
                cmd.Parameters.AddWithValue("@ADI", model.ADI ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@SOYADI", model.SOYADI ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@TC_NO", model.TC_NO ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@GSM_1", model.GSM_1 ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@GSM_2", model.GSM_2 ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@KIM_BABA_ADI", model.KIM_BABA_ADI ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@KIM_ANA_ADI", model.KIM_ANA_ADI ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@KIM_DOGUM_YERI", model.KIM_DOGUM_YERI ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@EV_ADRESI", model.EV_ADRESI ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ADAY_NO", model.ADAY_NO ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@SARI_NOTLAR", model.SARI_NOTLAR ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DOGUM_TARIHI", model.DOGUM_TARIHI);
                cmd.Parameters.AddWithValue("@KAYIT_TARIHI", model.KAYIT_TARIHI);
                cmd.Parameters.AddWithValue("@RESIM", (object)model.RESIM ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ID_GRUP_KARTI", model.ID_GRUP_KARTI);
                cmd.Parameters.AddWithValue("@SERTIFIKA_SINIFI", model.SERTIFIKA_SINIFI ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ONCE_SERT_SINIFI", model.ONCE_SERT_SINIFI ?? (object)DBNull.Value);

                await conn.OpenAsync();
                var result = await cmd.ExecuteScalarAsync();
                return Convert.ToInt32(result);
            }
        }

        public async Task UpdateKursiyerAsync(Kursiyer_Model model)
        {
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(@"
                UPDATE KURSIYER SET
                    ADI=@ADI,
                    SOYADI=@SOYADI,
                    TC_NO=@TC_NO,
                    GSM_1=@GSM_1,
                    GSM_2=@GSM_2,
                    KIM_BABA_ADI=@KIM_BABA_ADI,
                    KIM_ANA_ADI=@KIM_ANA_ADI,
                    KIM_DOGUM_YERI=@KIM_DOGUM_YERI,
                    EV_ADRESI=@EV_ADRESI,
                    ADAY_NO=@ADAY_NO,
                    SARI_NOTLAR=@SARI_NOTLAR,
                    DOGUM_TARIHI=@DOGUM_TARIHI,
                    KAYIT_TARIHI=@KAYIT_TARIHI,
                    RESIM=@RESIM,
                    ID_GRUP_KARTI=@ID_GRUP_KARTI,
                    SERTIFIKA_SINIFI=@SERTIFIKA_SINIFI,
                    ONCE_SERT_SINIFI=@ONCE_SERT_SINIFI
                WHERE ID=@ID", conn))
            {
                cmd.Parameters.AddWithValue("@ID", model.ID);
                cmd.Parameters.AddWithValue("@ADI", model.ADI ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@SOYADI", model.SOYADI ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@TC_NO", model.TC_NO ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@GSM_1", model.GSM_1 ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@GSM_2", model.GSM_2 ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@KIM_BABA_ADI", model.KIM_BABA_ADI ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@KIM_ANA_ADI", model.KIM_ANA_ADI ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@KIM_DOGUM_YERI", model.KIM_DOGUM_YERI ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@EV_ADRESI", model.EV_ADRESI ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ADAY_NO", model.ADAY_NO ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@SARI_NOTLAR", model.SARI_NOTLAR ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DOGUM_TARIHI", model.DOGUM_TARIHI);
                cmd.Parameters.AddWithValue("@KAYIT_TARIHI", model.KAYIT_TARIHI);
                cmd.Parameters.AddWithValue("@RESIM", (object)model.RESIM ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ID_GRUP_KARTI", model.ID_GRUP_KARTI);
                cmd.Parameters.AddWithValue("@SERTIFIKA_SINIFI", model.SERTIFIKA_SINIFI ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ONCE_SERT_SINIFI", model.ONCE_SERT_SINIFI ?? (object)DBNull.Value);

                await conn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
        }
       
        public async Task DeleteKursiyerAsync(int id)
        {
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand("DELETE FROM KURSIYER WHERE ID=@ID", conn))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                await conn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
        }
       
       
        
       
        }




    }


