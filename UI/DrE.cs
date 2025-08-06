using Entity;
using Entity.DTOs;
using Newtonsoft.Json;
using System.Net.Http;

namespace UI
{
    public partial class DrE : DevExpress.XtraEditors.XtraForm
    {
        static string baseUrl = "https://localhost:44352/api/";
        private int _id;
        public DrE(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void DrE_Load(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = baseUrl + "Dr/" + _id;

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    Doktorlar dr = JsonConvert.DeserializeObject<Doktorlar>(jsonResponse);
                    var TEMP = new DrDTO
                    {
                        Id = dr.Id,
                        Name = dr.Name,
                        Surname = dr.Soyad,
                        Specialization = dr.UzmanlikAlani,
                        PhoneNumber = dr.TelefonNumarasi,
                        vailability = dr.AktifMi

                    };
                    textEdit1.Text = TEMP.Name;
                    textEdit2.Text = TEMP.Surname;
                    textEdit3.Text = TEMP.Specialization;
                    textEdit4.Text = TEMP.PhoneNumber;
                    ChAct.Checked = TEMP.vailability;



                }
                else
                {
                    // API'den başarısız bir cevap gelirse hata mesajını göster
                    string errorContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"yüklenirken bir hata oluştu. Durum Kodu: {response.StatusCode}\nMesaj: {errorContent}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            string apiUrl = baseUrl + "Dr/";
            var TEMP = new DrDTO
            {
                Id = (int)_id,
                Name = textEdit1.Text,
                Surname = textEdit2.Text,
                Specialization = textEdit3.Text,
                PhoneNumber = textEdit4.Text,
                vailability = ChAct.Checked
            };
            using (HttpClient client = new HttpClient())
            {
                String DATA = JsonConvert.SerializeObject(TEMP);
                HttpContent content = new StringContent(DATA, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PutAsync(apiUrl, content);
                if (response.IsSuccessStatusCode)
                {

                    MessageBox.Show("Doktor Başarıyla Güncellendi! ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // API'den başarısız bir cevap gelirse hata mesajını göster
                    string errorContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Doktor yüklenirken bir hata oluştu. Durum Kodu: {response.StatusCode}\nMesaj: {errorContent}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}