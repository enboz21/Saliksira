using Entity.DTOs;
using System.Net.Http;
using UI.Core;
using UI.Core.Interface;

namespace UI
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        private readonly IUIDrSer _uIDrSer;
        private readonly IUIPtSer _uIPtSer;
        private readonly HttpClient _httpClient = Program.HTTP;
        public XtraForm1()
        {
            _uIDrSer = new UIDrSer(_httpClient);
            _uIPtSer = new UIPtSer(_httpClient);
            InitializeComponent();
            DrRef();
            PtRef();
        }
        private async void DrRef()
        {
            try
            {
                List<DrDTO> DR = await _uIDrSer.DrListAll();
                LeftGridControl.DataSource = DR;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri çekilirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void PtRef()
        {
            try
            {
                List<PtDTO> PT = await _uIPtSer.PtListAll();
                RightGridControl.DataSource = PT;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri çekilirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void DrRefresh_Click(object sender, EventArgs e)
        {
            DrRef();
        }

        private async void hastalar_Click(object sender, EventArgs e)
        {
            PtRef();
        }

        private void Drce_Click(object sender, EventArgs e)
        {
            using (DrC drce = new DrC())
            {
                drce.ShowDialog();
            }
        }

        private async void DrD_Click(object sender, EventArgs e)
        {
            try
            {
                _uIDrSer.Drdelete(Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id")));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"doktor silinirken hata {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DrRef();
        }

        private async void PtD_Click(object sender, EventArgs e)
        {
            try
            {
                _uIPtSer.Ptdelete(Convert.ToInt32(gridView2.GetFocusedRowCellValue("Id")));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hastalar silinirken hata {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            PtRef();
        }

        private void Ptce_Click(object sender, EventArgs e)
        {
            using (PtC ptce = new PtC())
            {
                ptce.ShowDialog();
            }
        }

        private void XtraForm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            using (StartForm Sf = new StartForm())
            {
                this.Hide();
                Sf.ShowDialog();
            }

        }

        private void ta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (Takip ta = new Takip())
            {
                ta.ShowDialog();
            }
        }

        private void DRE_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object selectedRow = gridView1.GetFocusedRowCellValue("Id");
            using (DrE drE = new DrE(Convert.ToInt32(selectedRow)))
            {
                drE.ShowDialog();
            }

        }

        private void PtE_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object selectedRow = gridView2.GetFocusedRowCellValue("Id");
            using (PtE ptE = new PtE(Convert.ToInt32(selectedRow)))
            {
                ptE.ShowDialog();
            }
        }

    }
}