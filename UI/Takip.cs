using Entity.DTOs;
using Newtonsoft.Json;
using System.Net.Http;

namespace UI
{
    public partial class Takip : DevExpress.XtraEditors.XtraForm
    {
        private const string baseUrl = Program.BaseUrl+"/";
        public Takip()
        {
            InitializeComponent();
        }

        private async void Takip_Load(object sender, EventArgs e)
        {
            refle();
        }

        private async void onay_Click(object sender, EventArgs e)
        {
            object selectedRow = gridView1.GetFocusedRowCellValue("Id");

            string apiUrl = baseUrl + "Or/" + selectedRow;
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.DeleteAsync(apiUrl);
                refle();
            }
        }
        public async void refle()
        {
            string apiUrl = baseUrl + "Or";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    List<OrDTOE> doktorListesi = JsonConvert.DeserializeObject<List<OrDTOE>>(jsonResponse);
                    gridControl1.DataSource = doktorListesi;
                }
                else
                {
                    gridControl1.DataSource = null;
                    // API'den başarısız bir cevap gelirse hata mesajını göster
                    string errorContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($" hasta kalmadı", "Bildiri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}