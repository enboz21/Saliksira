using System;
using System.IO;
using System.Windows.Forms; // MessageBox i�in eklendi

namespace UI
{
    internal static class Program
    {
        public static string BaseUrl;

        [STAThread]
        static void Main()
        {
            const string dosyaAdi = "BaseUrl.txt";
            const string varsayilanUrl = "https://localhost:44352/api/";

            try
            {
                // Dosya mevcutsa okuma i�lemi yap�l�r.
                using (StreamReader sr = new StreamReader(dosyaAdi))
                {
                    BaseUrl = sr.ReadLine();
                    if (string.IsNullOrWhiteSpace(BaseUrl))
                    {
                        // Dosya bo�sa varsay�lan de�eri kullan�r.
                        BaseUrl = varsayilanUrl;
                        MessageBox.Show($"Dosya '{dosyaAdi}' bo� oldu�u i�in varsay�lan URL kullan�l�yor: {BaseUrl}", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                // Dosya bulunamazsa olu�turulur ve i�ine varsay�lan de�er yaz�l�r.
                try
                {
                    File.WriteAllText(dosyaAdi, varsayilanUrl);
                    BaseUrl = varsayilanUrl;
                    MessageBox.Show($"Dosya '{dosyaAdi}' bulunamad�. Yeni dosya olu�turuldu ve varsay�lan URL atand�: {BaseUrl}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Dosya olu�turulurken bir hata olu�tu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Uygulamay� ba�latmadan ��k.
                }
            }
            catch (Exception ex)
            {
                // Di�er t�m hatalar yakalan�r.
                MessageBox.Show($"Bir hata olu�tu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Uygulamay� ba�latmadan ��k.
            }

            // Dosya okuma veya olu�turma i�lemi ba�ar�l�ysa uygulama ba�lat�l�r.
            ApplicationConfiguration.Initialize();
            Application.Run(new StartForm());
        }
    }
}