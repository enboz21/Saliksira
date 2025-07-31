using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Entity.DTOs; // PtDTO sınıfı için gerekli

namespace UI
{
    public partial class StartForm : DevExpress.XtraEditors.XtraForm
    {
        public StartForm()
        {
            InitializeComponent();
            panel2.Visible = false;
        }

        static string baseUrl = "https://localhost:44352/api/";
        private void label1_Click(object sender, EventArgs e)
        {
            // Bu metot boş bırakılabilir veya ihtiyaca göre doldurulabilir.
        }

        private void Giris_Click(object sender, EventArgs e)
        {
            XtraForm1 xtraForm1 = new XtraForm1();
            this.Hide();
            xtraForm1.ShowDialog();
        }

        // textEdit1_EditValueChanged metodunu async olarak işaretliyoruz.
        private async void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (textEdit1.Text.Length > 10)
            {
                // await ile AdAsync metodunun tamamlanmasını bekliyoruz.
                string hastaAdi = await AdAsync(textEdit1.Text);

                // Eğer hasta adı başarıyla alındıysa, textEdit2'yi güncelliyoruz.
                if (!string.IsNullOrEmpty(hastaAdi))
                {
                    textEdit2.Text = hastaAdi + " Hoşgeldiniz";
                    panel2.Visible = true;

                    // Task.Delay ile 3 saniye bekliyor ve sonra UI elemanlarını güncelliyoruz.
                    // ContinueWith ile UI thread'inde işlem yapmak için BeginInvoke kullanıyoruz.
                    await Task.Delay(3000);

                    // BeginInvoke yerine async/await kullanarak daha temiz bir kod yazabiliriz.
                    this.Invoke((Action)(() =>
                    {
                        panel2.Visible = false;
                        textEdit1.EditValue = null;
                        textEdit1.Focus();
                    }));
                }
            }
        }

        private async Task<string> AdAsync(string a)
        {
            using (HttpClient client = new HttpClient())
            {
                // Rota, API'daki 'Pt/by-tc/{a}' rotasına göre düzenlenmiş.
                string apiUrl = baseUrl + "Pt/by-tc/" + a;

                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonString = await response.Content.ReadAsStringAsync();

                        try
                        {
                            // JSON verisini PtDTO nesnesine dönüştürmeye çalışıyoruz.
                            PtDTO hastaBilgisi = JsonSerializer.Deserialize<PtDTO>(jsonString);

                            // JSON verisinden Name ve Surname alanlarını kontrol edip birleştiriyoruz.
                            if (hastaBilgisi != null && !string.IsNullOrEmpty(hastaBilgisi.Name))
                            {
                                // Eğer Surname de varsa birleştir
                                if (!string.IsNullOrEmpty(hastaBilgisi.Surname))
                                {
                                    return $"{hastaBilgisi.Name} {hastaBilgisi.Surname}";
                                }
                                return hastaBilgisi.Name;
                            }
                            else
                            {
                                // İsim alanı boşsa veya bulunamazsa
                                MessageBox.Show("Gelen veride hasta adı bulunamadı.", "Veri Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return string.Empty;
                            }
                        }
                        catch (JsonException ex)
                        {
                            MessageBox.Show($"Gelen veri JSON formatında değil: {ex.Message}", "Veri Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return string.Empty;
                        }
                    }
                    else
                    {
                        // Başarısız durum kodlarını (404 Not Found, 500 Internal Server Error vb.) ele alıyoruz.
                        string errorContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"API'den hata döndü: {response.StatusCode}\nMesaj: {errorContent}", "API Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return string.Empty;
                    }
                }
                catch (HttpRequestException ex)
                {
                    // Ağ bağlantısı veya API'ye ulaşılamaması gibi hataları yakalıyoruz.
                    MessageBox.Show($"API'ye bağlanırken bir hata oluştu: {ex.Message}\nLütfen Web API'nizin çalıştığından emin olun.", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return string.Empty;
                }
            }
        }
    }
}