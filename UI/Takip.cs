using DevExpress.XtraEditors;
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
        private readonly IUIDrSer _uIDrSer;
        public Takip()
        {
            _uIDrSer = new UIDrSer(_httpClient);
            _uIOrSer = new UIOrSer(_httpClient);
            InitializeComponent();
        }

        private async void Takip_Load(object sender, EventArgs e)
        {
            dok.Properties.DataSource=await _uIDrSer.DrListAll();
            dok.Properties.DisplayMember = "Name";
            dok.Properties.ValueMember = "Id";
        }

        private async void onay_Click(object sender, EventArgs e)
        {
            object selectedRow = gridView1.GetFocusedRowCellValue("Id");
            try
            {
                await _uIOrSer.Delete(Convert.ToInt32(selectedRow));
                refle((int)dok.EditValue);
            }
            catch (Exception ex)
            {
                gridControl1.DataSource = null;
            }
        }
        public async void refle(int DrID)
        {
            try
            {
                var TEMP = await _uIOrSer.GetByDrID(DrID);
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

        private void dok_EditValueChanged(object sender, EventArgs e)
        {
            refle((int)dok.EditValue);
        }
    }
}