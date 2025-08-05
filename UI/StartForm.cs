using Entity.DTOs; // PtDTO sınıfı için gerekli
using Newtonsoft.Json;
using System.Net.Http;

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
            if (textEdit1.Text.Length == 11)
            {
                // UI'ın bloke olmaması için await kullanıyoruz.
                string[] hastaAdi = await AdAsync(textEdit1.Text);
                if (hastaAdi!=null) {
                    try
                    {
                        // Eğer hasta adı başarıyla alındıysa, işlemleri başlat.

                        // Bu satır await sonrasında otomatik olarak UI thread'inde çalışır.
                        textEdit2.Text = hastaAdi[0] + " Hoşgeldiniz";
                        textEdit3.Text = "Doktorunuz : " + hastaAdi[1];
                        Add(Convert.ToInt32(hastaAdi[3]), Convert.ToInt32(hastaAdi[2]));
                        panel2.Visible = true;

                        // 3 saniye bekle. Bu süre boyunca UI donmaz.
                        await Task.Delay(3000);

                        // Gecikme bittikten sonra, bu satırlar da UI thread'inde çalışacaktır.
                        panel2.Visible = false;


                    }
                    catch (Exception s)
                    {

                    }
                }
                textEdit1.EditValue = null;
                textEdit1.Focus();

            }
        }

        private async Task<string[]> AdAsync(string a)
        {
            using (HttpClient client = new HttpClient())
            {
                // Rota, API'daki 'Pt/by-tc/{a}' rotasına göre düzenlenmiş.
                string apiUrl = baseUrl + "Pt/by-tc/" + a;

                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    string jsonString = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        PtDTO ptDto = JsonConvert.DeserializeObject<PtDTO>(jsonString);
                        String[] X = new string[4];

                        

                        X[0] = ptDto.Name;
                        X[1] = ptDto.DrName;
                        X[2] = Convert.ToString(ptDto.DrId);
                        X[3] = Convert.ToString(ptDto.Id);
                        


                        return X; // PtDTO'dan ismi alıyoruz.
                    }
                    return null;
                }
                catch (HttpRequestException ex)
                {
                    // Ağ bağlantısı veya API'ye ulaşılamaması gibi hataları yakalıyoruz.
                    MessageBox.Show($"API'ye bağlanırken bir hata oluştu: {ex.Message}\nLütfen Web API'nizin çalıştığından emin olun.", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
        private async Task Add(int Id, int DrId)
        {
            String apiUrl = baseUrl + "Or/" + Id;

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                string jsonString = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    apiUrl = baseUrl + "Or";
                    String DATA = JsonConvert.SerializeObject(new
                    {
                        hastaId = Id,
                        doktorId = DrId
                    });
                    HttpContent content = new StringContent(DATA, System.Text.Encoding.UTF8, "application/json");

                    HttpResponseMessage respone = await client.PostAsync(apiUrl, content);

                }


            }
        }
    }
}