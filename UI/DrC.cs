using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;

namespace UI
{
    public partial class DrC : DevExpress.XtraEditors.XtraForm
    {
        public DrC()
        {
            InitializeComponent();
        }
        static string baseUrl = "https://localhost:44352/api/";
        private async void Conf_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = baseUrl + "Dr";
                try
                {

                    String Name = textEdit1.Text,
                               Surname = textEdit2.Text,
                               Phone = textEdit4.Text,
                               Speciality = textEdit3.Text;
                    bool b = ChAct.Checked;
                    String DATA = JsonConvert.SerializeObject(new
                    {
                        name = Name,
                        Surname = Surname,
                        Specialization = Speciality,
                        PhoneNumber = Phone,
                        vailability = b
                    });
                    HttpContent content = new StringContent(DATA, System.Text.Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                    if (response.IsSuccessStatusCode)
                    {

                        MessageBox.Show("Doktorlar Başarıyla Yüklendi! " + b, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // API'den başarısız bir cevap gelirse hata mesajını göster
                        string errorContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Doktorlar yüklenirken bir hata oluştu. Durum Kodu: {response.StatusCode}\nMesaj: {errorContent}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (HttpRequestException ex)
                {
                    // Ağ bağlantısı veya API'ye ulaşılamaması gibi hataları yakala
                    MessageBox.Show($"API'ye bağlanırken bir hata oluştu: {ex.Message}\nLütfen Web API'nizin çalıştığından emin olun.", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        
    }
}