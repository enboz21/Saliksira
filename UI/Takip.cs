using DevExpress.XtraEditors;
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
using System.Windows.Forms;

namespace UI
{
    public partial class Takip : DevExpress.XtraEditors.XtraForm
    {
        static string baseUrl = "https://localhost:44352/api/";
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

            string apiUrl = baseUrl + "Or/"+selectedRow;
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
                    MessageBox.Show($"yüklenirken bir hata oluştu. Durum Kodu: {response.StatusCode}\nMesaj: {errorContent}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}