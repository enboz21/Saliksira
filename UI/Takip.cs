using Entity.DTOs;
using Newtonsoft.Json;
using System.Net.Http;
using UI.Core;
using UI.Core.Interface;

namespace UI
{
    public partial class Takip : DevExpress.XtraEditors.XtraForm
    {
        private readonly HttpClient _httpClient = Program.HTTP;
        private readonly IUIOrSer _uIOrSer;
        public Takip()
        {
            _uIOrSer = new UIOrSer(_httpClient);
            InitializeComponent();
        }

        private async void Takip_Load(object sender, EventArgs e)
        {
            refle();
        }

        private async void onay_Click(object sender, EventArgs e)
        {
            object selectedRow = gridView1.GetFocusedRowCellValue("Id");
            try
            {
                await _uIOrSer.Delete(Convert.ToInt32(selectedRow));
                refle();
            }
            catch (Exception ex)
            {
                gridControl1.DataSource = null;
            }
        }
        public async void refle()
        {
            try
            {
                var TEMP= await _uIOrSer.GetALL();
                if (TEMP != null)
                {
                    gridControl1.DataSource = TEMP;
                }
                else gridControl1.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri çekilirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}