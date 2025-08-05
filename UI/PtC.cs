using DevExpress.XtraEditors;
using Entity;
using Entity.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace UI
{
    public partial class PtC : DevExpress.XtraEditors.XtraForm
    {
        static string baseUrl = "https://localhost:44352/api/";

        public PtC()
        {
            InitializeComponent();
            
        }


        public async Task<List<GeDTO>> GetCinsiyetler()
        {
            string jsonResponse = "";
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = baseUrl + "Ge";
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    jsonResponse = await response.Content.ReadAsStringAsync();

                }
                else
                {
                    // API'den başarısız bir cevap gelirse hata mesajını göster
                    string errorContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"yüklenirken bir hata oluştu. Durum Kodu: {response.StatusCode}\nMesaj: {errorContent}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            List<GeDTO> cins = JsonConvert.DeserializeObject<List<GeDTO>>(jsonResponse);

            return cins;
        }
            public async Task<List<DrDTO>> Getdoktorlar()
        {
            string jsonResponse = "";
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = baseUrl + "Dr";
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    jsonResponse = await response.Content.ReadAsStringAsync();

                }
                else
                {
                    // API'den başarısız bir cevap gelirse hata mesajını göster
                    string errorContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"yüklenirken bir hata oluştu. Durum Kodu: {response.StatusCode}\nMesaj: {errorContent}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // JSON verisini Cinsiyet listesine dönüştürme
            List<DrDTO> doktorlar = JsonConvert.DeserializeObject<List<DrDTO>>(jsonResponse);

            return doktorlar;
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = baseUrl + "Pt";
                try
                {
                    DateTime? secilenDateTime = dateEdit1.EditValue as DateTime?; // Nullable DateTime olarak alıyoruz
                    if (secilenDateTime.HasValue)
                    {
                        // DateOnly.FromDateTime() metodu, bir DateTime nesnesinden sadece tarih kısmını alır.
                        DateOnly secilenDateOnly = DateOnly.FromDateTime(secilenDateTime.Value);
                        String DATA = JsonConvert.SerializeObject(new
                        {
                            name = textEdit1.Text,
                            Surname = textEdit2.Text,
                            TcNo = textEdit3.Text,
                            BirthDate = secilenDateOnly,
                            genderid = lookUpEdit1.EditValue,
                            PhoneNumber = textEdit6.Text,
                            Address = textEdit7.Text,
                            DrId = lookUpEdit2.EditValue
                        });
                        HttpContent content = new StringContent(DATA, System.Text.Encoding.UTF8, "application/json");

                        HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                        if (response.IsSuccessStatusCode)
                        {

                            MessageBox.Show("Hasta Başarıyla Yüklendi! ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // API'den başarısız bir cevap gelirse hata mesajını göster
                            string errorContent = await response.Content.ReadAsStringAsync();
                            MessageBox.Show($"Hasta yüklenirken bir hata oluştu. Durum Kodu: {response.StatusCode}\nMesaj: {errorContent}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                    }
                    else
                    {
                        MessageBox.Show("Lütfen bir tarih seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
                catch (HttpRequestException ex)
                {
                    // Ağ bağlantısı veya API'ye ulaşılamaması gibi hataları yakala
                    MessageBox.Show($"API'ye bağlanırken bir hata oluştu: {ex.Message}\nLütfen Web API'nizin çalıştığından emin olun.", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private async void  PtCE_Load(object sender, EventArgs e)
        {
            List<GeDTO> cinsiyetler = await GetCinsiyetler();

            // ComboBoxEdit kontrolünü yapılandırma
            lookUpEdit1.Properties.DataSource = cinsiyetler;
            lookUpEdit1.Properties.DisplayMember = "cins";
            lookUpEdit1.Properties.ValueMember = "Id";

            List<DrDTO> doktorlar = await Getdoktorlar();
            lookUpEdit2.Properties.DataSource = doktorlar;
            lookUpEdit2.Properties.DisplayMember = "Name";
            lookUpEdit2.Properties.ValueMember = "Id";
        }
    }
}