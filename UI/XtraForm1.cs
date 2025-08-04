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
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;

namespace UI
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        static string baseUrl = "https://localhost:44352/api/";
        public XtraForm1()
        {
            InitializeComponent();
            TableRefresh("Pt", false);
            TableRefresh("Dr", false);
        }

        private async void DrRefresh_Click(object sender, EventArgs e)
        {


            TableRefresh("Dr", true);
        }

        private async void hastalar_Click(object sender, EventArgs e)
        {
            TableRefresh("Pt", true);
        }

        private void Drce_Click(object sender, EventArgs e)
        {
            using (DrCE drce = new DrCE())
            {
                drce.ShowDialog();
            }
        }

        private void RightGridControl_Click(object sender, EventArgs e)
        {

        }

        private void DrD_Click(object sender, EventArgs e)
        {
            Delete("Dr");
        }

        private async void Delete(String a)
        {
            object selectedRow;
            if (a.Equals("Dr"))
            {
                selectedRow = gridView1.GetFocusedRowCellValue("Id");
            }
            else if (a.Equals("Pt"))
            {
                selectedRow = gridView2.GetFocusedRowCellValue("Id");
            }
            else
            {
                MessageBox.Show("Hatalı işlem", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selectedRow != null)
            {
                int id = Convert.ToInt32(selectedRow);
                var d = MessageBox.Show($"Seçilen ID: {id} \n eminmisiniz", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    using (HttpClient client = new())
                    {
                        String apiUrl = baseUrl + a + "/" + id;
                        try
                        {
                            HttpResponseMessage response = await client.DeleteAsync(apiUrl);
                            if (response.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Silme işlemi başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TableRefresh(a, false);
                            }
                            else
                            {
                                // API'den başarısız bir cevap gelirse hata mesajını göster
                                string errorContent = await response.Content.ReadAsStringAsync();
                                MessageBox.Show($"Silme işlemi sırasında bir hata oluştu. Durum Kodu: {response.StatusCode}\nMesaj: {errorContent}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private async void TableRefresh(String a, bool box)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = baseUrl + a;
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        if (a.Equals("Dr"))
                        {
                            // Doktor verilerini deserialize et ve grid'e ata
                            List<DrDTO> Hasta = JsonConvert.DeserializeObject<List<DrDTO>>(jsonResponse);
                            LeftGridControl.DataSource = Hasta;
                        }
                        else if (a.Equals("Pt"))
                        {
                            // Hasta verilerini deserialize et ve grid'e ata
                            List<PtDTO> HAS = JsonConvert.DeserializeObject<List<PtDTO>>(jsonResponse);
                            RightGridControl.DataSource = HAS;
                        }
                        if (box)
                        {
                            MessageBox.Show("Başarıyla Yüklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        // API'den başarısız bir cevap gelirse hata mesajını göster
                        string errorContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"yüklenirken bir hata oluştu. Durum Kodu: {response.StatusCode}\nMesaj: {errorContent}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (HttpRequestException ex)
                {
                    // Ağ bağlantısı veya API'ye ulaşılamaması gibi hataları yakala
                    MessageBox.Show($"API'ye bağlanırken bir hata oluştu: {ex.Message}\nLütfen Web API'nizin çalıştığından emin olun.", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void PtD_Click(object sender, EventArgs e)
        {
            Delete("Pt");
        }

        private void Ptce_Click(object sender, EventArgs e)
        {
            using (PtCE ptce = new PtCE())
            {
                ptce.ShowDialog();
            }
        }

        private void XtraForm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            StartForm Sf = new StartForm();
            this.Hide();
            Sf.ShowDialog();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {   
            Takip ta = new Takip();
            ta.ShowDialog();
        }
    }
}