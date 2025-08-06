using Entity;
using Entity.DTOs;
using Newtonsoft.Json;
using System.Net.Http;
using UI.Core.Interface;

namespace UI.Core
{
    internal class UIDrSer : IUIDrSer
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = Program.BaseUrl+"/Dr";
        public UIDrSer(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async void Drdelete(int ID)
        {
            if (ID == 0)
            {
                throw new ArgumentException("Silinecek doktor seçilmedi.");
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

        public async Task<List<DrDTO>> DrListAll()
        {
            List<DrDTO> DR;
            HttpResponseMessage response = await _httpClient.GetAsync(BaseUrl);
            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                DR = JsonConvert.DeserializeObject<List<DrDTO>>(jsonResponse);
                return DR;
            }
            else
            {
                string errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Silme işlemi sırasında bir hata oluştu: {response.StatusCode} - {errorContent}");
            }
        }

        public async Task<DrDTO> GetDrId(int ID)
        {
            string apiUrl = BaseUrl + "/" + ID;
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                Doktorlar dr = JsonConvert.DeserializeObject<Doktorlar>(jsonResponse);
                var TEMP = new DrDTO
                {
                    Id = dr.Id,
                    Name = dr.Name,
                    Surname = dr.Soyad,
                    Specialization = dr.UzmanlikAlani,
                    PhoneNumber = dr.TelefonNumarasi,
                    vailability = dr.AktifMi

                };
                return TEMP;
            }
            else
            {
                string errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Doktor bilgileri çekilemedi: {response.StatusCode} - {errorContent}");
            }
        }

        public async void DrUp(DrDTO TEMP)
        {
            String DATA = JsonConvert.SerializeObject(TEMP);
            HttpContent content = new StringContent(DATA, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PutAsync(BaseUrl, content);
            if (response.IsSuccessStatusCode)
            {

                MessageBox.Show("Doktor Başarıyla Güncellendi! ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // API'den başarısız bir cevap gelirse hata mesajını göster
                string errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Doktor güncellenirken hata oluştu : {response.StatusCode} - {errorContent}");
            }
        }

        public async void DrPost(DrDTO TEMP)
        {
            String DATA = JsonConvert.SerializeObject(TEMP);
            HttpContent content = new StringContent(DATA, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync(BaseUrl, content);
            if (response.IsSuccessStatusCode)
            {

                MessageBox.Show("Doktorlar Başarıyla Yüklendi! ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Doktor eklenirken bir sorun oluştu \n : {response.StatusCode} - {errorContent}");
            }
        }
    }
}
