using System;
using System.IO;
using System.Windows.Forms; // MessageBox için eklendi

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
                // Dosya mevcutsa okuma iþlemi yapýlýr.
                using (StreamReader sr = new StreamReader(dosyaAdi))
                {
                    BaseUrl = sr.ReadLine();
                    if (string.IsNullOrWhiteSpace(BaseUrl))
                    {
                        // Dosya boþsa varsayýlan deðeri kullanýr.
                        BaseUrl = varsayilanUrl;
                        MessageBox.Show($"Dosya '{dosyaAdi}' boþ olduðu için varsayýlan URL kullanýlýyor: {BaseUrl}", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                // Dosya bulunamazsa oluþturulur ve içine varsayýlan deðer yazýlýr.
                try
                {
                    File.WriteAllText(dosyaAdi, varsayilanUrl);
                    BaseUrl = varsayilanUrl;
                    MessageBox.Show($"Dosya '{dosyaAdi}' bulunamadý. Yeni dosya oluþturuldu ve varsayýlan URL atandý: {BaseUrl}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Dosya oluþturulurken bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Uygulamayý baþlatmadan çýk.
                }
            }
            catch (Exception ex)
            {
                // Diðer tüm hatalar yakalanýr.
                MessageBox.Show($"Bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Uygulamayý baþlatmadan çýk.
            }

            // Dosya okuma veya oluþturma iþlemi baþarýlýysa uygulama baþlatýlýr.
            ApplicationConfiguration.Initialize();
            Application.Run(new StartForm());
        }
    }
}