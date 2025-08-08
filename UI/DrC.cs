using Entity.DTOs;
using System.Net.Http;
using UI.Core;
using UI.Core.Interface;

namespace UI
{
    public partial class DrC : DevExpress.XtraEditors.XtraForm
    {
        private readonly IUIDrSer _uIDrSer;
        private readonly HttpClient _httpClient = Program.HTTP;

        public DrC()
        {
            _uIDrSer = new UIDrSer(_httpClient);
            InitializeComponent();
        }
        private void Conf_Click(object sender, EventArgs e)
        {
                try
                {
                    DrDTO DATA = new DrDTO
                    {
                        Name = textEdit1.Text,
                        Surname = textEdit2.Text,
                        Specialization = textEdit4.Text,
                        PhoneNumber = textEdit3.Text,
                        vailability = ChAct.Checked
                    };
                    _uIDrSer.DrPost(DATA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Doktor kaydetme işleminin bir yerinde hata: \n {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            

        }


    }
}