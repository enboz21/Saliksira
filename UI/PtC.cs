using Entity.DTOs;
using Newtonsoft.Json;
using System.Net.Http;
using UI.Core;
using UI.Core.Interface;

namespace UI
{
    public partial class PtC : DevExpress.XtraEditors.XtraForm
    {
        static string baseUrl = "https://localhost:44352/api/";
        private readonly IUIPtSer _uIPtSer;
        private readonly IUIGeSer _uIGeSer;
        private readonly IUIDrSer _uIDrSer;
        private readonly HttpClient _httpClient;
        public PtC()
        {
            _httpClient = new HttpClient();
            _uIGeSer = new UIGeSer(_httpClient);
            _uIPtSer = new UIPtSer(_httpClient);
            _uIDrSer = new UIDrSer(_httpClient);
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
                    string errorContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"yüklenirken bir hata oluştu. Durum Kodu: {response.StatusCode}\nMesaj: {errorContent}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            List<DrDTO> doktorlar = JsonConvert.DeserializeObject<List<DrDTO>>(jsonResponse);
            return doktorlar;
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime birthDateAsDateTime = (DateTime)dateEdit1.EditValue;
                DateOnly birthDateAsDateOnly = DateOnly.FromDateTime(birthDateAsDateTime);
                PtDTO DATA = new PtDTO
                {
                    Name = textEdit1.Text,
                    Surname = textEdit2.Text,
                    TcNo = textEdit3.Text,
                    BirthDate = birthDateAsDateOnly,
                    Genderid = (int)lookUpEdit1.EditValue,
                    PhoneNumber = textEdit6.Text,
                    Address = textEdit7.Text,
                    DrId = (int)lookUpEdit2.EditValue
                };
                _uIPtSer.PtPost(DATA);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hasta kaydedilirken bir hata oluştu: \n {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void PtCE_Load(object sender, EventArgs e)
        {
            List<GeDTO> cinsiyetler = await _uIGeSer.GetAll();
            lookUpEdit1.Properties.DataSource = cinsiyetler;
            lookUpEdit1.Properties.DisplayMember = "cins";
            lookUpEdit1.Properties.ValueMember = "Id";

            List<DrDTO> doktorlar = await _uIDrSer.DrListAll();
            lookUpEdit2.Properties.DataSource = doktorlar;
            lookUpEdit2.Properties.DisplayMember = "Name";
            lookUpEdit2.Properties.ValueMember = "Id";
        }
    }
}