using Entity.DTOs;
using System.Net.Http;
using UI.Core;
using UI.Core.Interface;

namespace UI
{
    public partial class PtE : DevExpress.XtraEditors.XtraForm
    {
        static string baseUrl = "https://localhost:44352/api/";
        private int _id;
        private readonly IUIPtSer _uIPtSer;
        private readonly HttpClient _httpClient;
        private readonly IUIGeSer _uIGeSer;
        private readonly IUIDrSer _uIDrSer;
        public PtE(int id)
        {
            _httpClient = new HttpClient();
            _uIPtSer = new UIPtSer(_httpClient);
            _uIGeSer = new UIGeSer(_httpClient);
            _uIDrSer = new UIDrSer(_httpClient);
            InitializeComponent();
            _id = id;
        }

        private async void PtE_Load(object sender, EventArgs e)
        {
            try
            {
                var TEMP = await _uIPtSer.PtId(_id);
                textEdit1.Text = TEMP.Name;
                textEdit2.Text = TEMP.Surname;
                textEdit3.Text = TEMP.TcNo;
                textEdit6.Text = TEMP.PhoneNumber;
                textEdit7.Text = TEMP.Address;
                List<GeDTO> cinsiyetler = await _uIGeSer.GetAll();

                lookUpEdit1.Properties.DataSource = cinsiyetler;
                lookUpEdit1.Properties.DisplayMember = "cins";
                lookUpEdit1.Properties.ValueMember = "Id";

                List<DrDTO> doktorlar = await _uIDrSer.DrListAll();
                lookUpEdit2.Properties.DataSource = doktorlar;
                lookUpEdit2.Properties.DisplayMember = "Name";
                lookUpEdit2.Properties.ValueMember = "Id";

                lookUpEdit2.EditValue = TEMP.DrId;
                lookUpEdit1.EditValue = TEMP.Genderid;
                dateEdit1.EditValue = TEMP.BirthDate;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"kişi kaydı yüklenirken hata : {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void simpleButton1_Click_1(object sender, EventArgs e)
        {
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

            try
            {
                _uIPtSer.Ptup(TEMP);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"kayıt sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
