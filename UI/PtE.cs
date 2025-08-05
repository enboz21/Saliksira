using Entity;
using Entity.DTOs;
using Newtonsoft.Json;
using System.Net.Http;

namespace UI
{
    public partial class PtE : DevExpress.XtraEditors.XtraForm
    {
        static string baseUrl = "https://localhost:44352/api/";
        private int _id;
        public PtE(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void PtE_Load(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = baseUrl + "Pt/" + _id;

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    Hastalar pt = JsonConvert.DeserializeObject<Hastalar>(jsonResponse);
                    var TEMP = new PtDTO
                    {
                        Name = pt.Name,
                        Surname = pt.Soyad,
                        TcNo = pt.TckimlikNo,
                        BirthDate = pt.DogumTarihi,
                        PhoneNumber = pt.TelefonNumarasi,
                        Genderid = (byte)pt.Cinsid,
                        Address = pt.Adres,
                        DrId = pt.Doktorid
                    };
                    textEdit1.Text = TEMP.Name;
                    textEdit2.Text = TEMP.Surname;
                    textEdit3.Text = TEMP.TcNo;
                    textEdit6.Text = TEMP.PhoneNumber;
                    textEdit7.Text = TEMP.Address;
                    List<GeDTO> cinsiyetler = await GetCinsiyetler();

                    // ComboBoxEdit kontrolünü yapılandırma
                    lookUpEdit1.Properties.DataSource = cinsiyetler;
                    lookUpEdit1.Properties.DisplayMember = "cins";
                    lookUpEdit1.Properties.ValueMember = "Id";

                    List<DrDTO> doktorlar = await Getdoktorlar();
                    lookUpEdit2.Properties.DataSource = doktorlar;
                    lookUpEdit2.Properties.DisplayMember = "Name";
                    lookUpEdit2.Properties.ValueMember = "Id";

                    lookUpEdit2.EditValue = TEMP.DrId;
                    lookUpEdit1.EditValue = TEMP.Genderid;
                    dateEdit1.EditValue = TEMP.BirthDate;
                }
                else
                {
                    // API'den başarısız bir cevap gelirse hata mesajını göster
                    string errorContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"yüklenirken bir hata oluştu. Durum Kodu: {response.StatusCode}\nMesaj: {errorContent}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private async void simpleButton1_Click_1(object sender, EventArgs e)
        {
            string apiUrl = baseUrl + "Pt";
            var TEMP = new PtDTO
            {
                Id = _id,
                Name = textEdit1.Text,
                Surname = textEdit2.Text,
                TcNo = textEdit3.Text,
                BirthDate = (DateOnly)dateEdit1.EditValue,
                Genderid = (int)lookUpEdit1.EditValue,
                PhoneNumber = textEdit6.Text,
                Address = textEdit7.Text,
                DrId = (int)lookUpEdit2.EditValue
            };
            using (HttpClient client = new HttpClient())
            {
                String DATA = JsonConvert.SerializeObject(TEMP);
                HttpContent content = new StringContent(DATA, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PutAsync(apiUrl, content);
                if (response.IsSuccessStatusCode)
                {

                    MessageBox.Show("hasta Başarıyla Güncellendi! ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // API'den başarısız bir cevap gelirse hata mesajını göster
                    string errorContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"hasta yüklenirken bir hata oluştu. Durum Kodu: {response.StatusCode}\nMesaj: {errorContent}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
