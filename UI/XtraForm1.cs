using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Newtonsoft.Json;
using Entity.DTOs;

namespace UI
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        static string baseUrl = "https://localhost:44352/api/";
        public XtraForm1()
        {
            InitializeComponent();
        }

        private async void DrRefresh_Click(object sender, EventArgs e)
        {


            using (HttpClient client = new HttpClient())
            {
                string apiUrl = baseUrl + "Dr";
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();


                        List<DrDTO> doktorListesi = JsonConvert.DeserializeObject<List<DrDTO>>(jsonResponse);
                        gridControl1.DataSource = doktorListesi;

                        MessageBox.Show("Doktorlar Başarıyla Yüklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private async void hastalar_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = baseUrl + "Pt";
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();


                        List<PtDTO> doktorListesi = JsonConvert.DeserializeObject<List<PtDTO>>(jsonResponse);
                        gridControl2.DataSource = doktorListesi;

                        MessageBox.Show("Doktorlar Başarıyla Yüklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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