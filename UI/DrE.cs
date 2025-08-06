using Entity.DTOs;
using System.Net.Http;
using UI.Core;
using UI.Core.Interface;

namespace UI
{
    public partial class DrE : DevExpress.XtraEditors.XtraForm
    {
        private int _id;
        private readonly IUIDrSer _uIDrSer;
        private readonly HttpClient _httpClient;
        public DrE(int id)
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            _uIDrSer = new UIDrSer(_httpClient);
            _id = id;
        }

        private async void DrE_Load(object sender, EventArgs e)
        {
            try
            {
                var TEMP = await _uIDrSer.GetDrId(_id);
                textEdit1.Text = TEMP.Name;
                textEdit2.Text = TEMP.Surname;
                textEdit3.Text = TEMP.Specialization;
                textEdit4.Text = TEMP.PhoneNumber;
                ChAct.Checked = TEMP.vailability;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"kişi kaydı yüklenirken hata : {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            var TEMP = new DrDTO
            {
                Id = _id,
                Name = textEdit1.Text,
                Surname = textEdit2.Text,
                Specialization = textEdit3.Text,
                PhoneNumber = textEdit4.Text,
                vailability = ChAct.Checked
            };
            try
            {
                _uIDrSer.DrUp(TEMP);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kişi kaydı güncellenirken hata \n : {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}