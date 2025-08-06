using Entity.DTOs;
using Newtonsoft.Json;
using System.Net.Http;
using UI.Core.Interface;

namespace UI.Core
{
    internal class UIDrSer : IUIDrSer
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://localhost:44352/api/Dr";
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
    }
}
