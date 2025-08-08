using System.Net.Http;
using UI.Core;
using UI.Core.Interface;

namespace UI
{

    public partial class StartForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IUIPtSer _uIPtSer;
        private readonly IUIOrSer _uIOrSer;
        private readonly HttpClient _httpClient = Program.HTTP;
        public StartForm()
        {
            _uIPtSer = new UIPtSer(_httpClient);
            _uIOrSer = new UIOrSer(_httpClient);
            InitializeComponent();
            panel2.Visible = false;
        }

        private static string baseUrl = Program.BaseUrl;

        private void Giris_Click(object sender, EventArgs e)
        {
            using (XtraForm1 xtraForm1 = new XtraForm1())
            {
                this.Hide();
                xtraForm1.ShowDialog();
            }
        }

        // textEdit1_EditValueChanged metodunu async olarak işaretliyoruz.
        private async void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (textEdit1.Text.Length == 11)
            {
                try
                {
                    // UI'ın bloke olmaması için await kullanıyoruz.
                    string[] hastaAdi = await _uIPtSer.Add(textEdit1.Text);
                    if (hastaAdi != null)
                    {
                        textEdit2.Text = hastaAdi[0] + " Hoşgeldiniz";
                        textEdit3.Text = "Doktorunuz : " + hastaAdi[1];
                        _uIOrSer.ADD(Convert.ToInt32(hastaAdi[3]), Convert.ToInt32(hastaAdi[2]));
                        panel2.Visible = true;
                        await Task.Delay(3000);
                        panel2.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"hasta sıraya eklenemedi: \n {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            textEdit1.EditValue = null;
            textEdit1.Focus();

        }
    }
}