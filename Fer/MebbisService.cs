using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Tarantula_MTSK.Services
{
    public class MebbisService
    {
        private readonly string _connectionString;

        public MebbisService(string connectionString)
        {
            _connectionString = connectionString;
        }


        // 🔹 Tüm dönemleri getir
        public async Task<DataTable> GetDonemlerAsync()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string sql = "SELECT DISTINCT DONEM_ADI FROM GRUP_KARTI ORDER BY DONEM_ADI";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    await conn.OpenAsync();
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }
        public async Task<DataTable> GetKursiyerVeEvrakByGrupIdAsync(int grupId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string sql = @"
SELECT 
    k.ADAY_NO,
    k.TC_NO,
    k.ADI,
    k.SOYADI,
    k.ONCE_SERT_SINIFI,
    k.SERTIFIKA_SINIFI,
    ev.EKSK_OGRNIM_BEL,
    ev.EKSK_SAGLIK,
    ev.EKSK_SAVCILIK,
    ev.EKSK_IMZA
FROM KURSIYER k
LEFT JOIN KURSIYER_EVRAK ev ON k.ID = ev.ID_KURSIYER
WHERE k.ID_GRUP_KARTI = @grupId
ORDER BY k.ADI, k.SOYADI";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@grupId", grupId);
                    await conn.OpenAsync();
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }
        // 🔹 Dönem adına göre GRUP_KARTI.ID getir
        public async Task<int?> GetGrupIdByDonemAsync(string donemAdi)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string sql = "SELECT TOP 1 ID FROM GRUP_KARTI WHERE DONEM_ADI = @donemAdi";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@donemAdi", donemAdi);
                    await conn.OpenAsync();
                    var result = await cmd.ExecuteScalarAsync();
                    return (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : (int?)null;
                }
            }
        }

        // 🔹 GrupId'ye göre kursiyerleri getir
        public async Task<DataTable> GetKursiyerByGrupIdAsync(int grupId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM KURSIYER WHERE ID_GRUP_KARTI = @grupId ORDER BY ADI, SOYADI";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@grupId", grupId);
                    await conn.OpenAsync();
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }
    }
}
