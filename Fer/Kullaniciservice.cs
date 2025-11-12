using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace Tarantula_MTSK.Services
{
    public class KullaniciService
    {
        private readonly string _connectionString;

        public KullaniciService(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Kullanıcı adı ve şifre doğrulaması yapar
        public async Task<bool> IsValidKullanici(string kullaniciAdi, string parola)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();

                    string query = "SELECT TOP 1 1 FROM KULLANICI WHERE KULLANICI_ADI = @KullaniciAdi AND KULLANICI_SIFRE = @Parola";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar).Value = kullaniciAdi;
                        command.Parameters.Add("@Parola", SqlDbType.NVarChar).Value = parola;

                        var result = await command.ExecuteScalarAsync();
                        return result != null; // Eğer bir sonuç dönerse kullanıcı geçerlidir
                    }
                }
            }
            catch (Exception ex)
            {
                LogError(ex);  // Hata loglama işlemi
                throw new InvalidOperationException("Veritabanı bağlantısında bir hata oluştu.");
            }
        }

        // Kullanıcı adlarını yükler (Login ekranında comboBox için)
        public async Task<List<string>> GetKullaniciAdlariAsync()
        {
            var kullaniciAdlari = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();

                    string query = "SELECT KULLANICI_ADI FROM KULLANICI";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = await command.ExecuteReaderAsync();

                        while (await reader.ReadAsync())
                        {
                            kullaniciAdlari.Add(reader["KULLANICI_ADI"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogError(ex);  // Hata loglama işlemi
                throw new InvalidOperationException("Veritabanından kullanıcı adı alınırken bir hata oluştu.");
            }

            return kullaniciAdlari;
        }

        // Hata loglama metodu
        private void LogError(Exception ex)
        {
            // Burada hata loglamayı gerçekleştirebilirsiniz (Dosyaya, Veritabanına, Log sistemine)
            // Örneğin:
            Console.WriteLine($"Error: {ex.Message}\n{ex.StackTrace}");
        }
    }
}
