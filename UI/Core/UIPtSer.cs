using Entity;
using Entity.DTOs;
using Newtonsoft.Json;
using System.Net.Http;
using UI.Core.Interface;

namespace UI.Core
{
    internal class UIPtSer : IUIPtSer
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = Program.BaseUrl+"/Pt";
        public UIPtSer(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async void Ptdelete(int ID)
        {
            if (ID == 0)
            {
                throw new ArgumentException("Silinecek hasta seçilmedi.");
            }
            var d = MessageBox.Show($"Seçilen ID: {ID} \n eminmisiniz", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {
                String apiUrl = BaseUrl + "/" + ID;
                HttpResponseMessage response = await _httpClient.DeleteAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Silme işlemi başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new HttpRequestException($"Silme işlemi sırasında bir hata oluştu: {response.StatusCode} - {errorContent}");
                }
            }
        }

        public async Task<List<PtDTO>> PtListAll()
        {
            List<PtDTO> PT;
            HttpResponseMessage response = await _httpClient.GetAsync(BaseUrl);
            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                PT = JsonConvert.DeserializeObject<List<PtDTO>>(jsonResponse);
                return PT;
            }
            else
            {
                string errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Silme işlemi sırasında bir hata oluştu: {response.StatusCode} - {errorContent}");
            }
        }
        public async Task<PtDTO> PtId(int ID)
        {
            HttpResponseMessage response;
            string apiUrl = BaseUrl + "/" + ID;
            response = await _httpClient.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                Hastalar pt = JsonConvert.DeserializeObject<Hastalar>(jsonResponse);
                var TEMP = new PtDTO
                {
                    Name = pt.Name,
                    Surname = pt.Soyad,
                    TcNo = pt.TckimlikNo,
                    BirthDate = pt.DogumTarihi,
                    PhoneNumber = pt.TelefonNumarasi,
                    Genderid = (byte)pt.Cinsid,
                    Address = pt.Adres,
                    DrId = pt.Doktorid
                };
                return TEMP;
            }
            else
            {
                string errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Silme işlemi sırasında bir hata oluştu: {response.StatusCode} - {errorContent}");
            }
        }

        public async void Ptup(PtDTO TEMP)
        {
            String DATA = JsonConvert.SerializeObject(TEMP);
            HttpContent content = new StringContent(DATA, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PutAsync(BaseUrl, content);
            if (response.IsSuccessStatusCode)
            {

                MessageBox.Show("hasta Başarıyla Güncellendi! ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // API'den başarısız bir cevap gelirse hata mesajını göster
                string errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"güncelleme başarısız: {response.StatusCode} - {errorContent} ");
            }
        }

        public async void PtPost(PtDTO TEMP)
        {
            String DATA = JsonConvert.SerializeObject(TEMP);
            HttpContent content = new StringContent(DATA, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync(BaseUrl, content);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Hasta Başarıyla Yüklendi! ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // API'den başarısız bir cevap gelirse hata mesajını göster
                string errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Yeni kayıt eklerken API taraflı hata: {response.StatusCode} - {errorContent} ");
            }
        }
    }
}
