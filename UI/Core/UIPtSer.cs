using Entity.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UI.Core.Interface;

namespace UI.Core
{
    internal class UIPtSer : IUIPtSer
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://localhost:44352/api/Pt";
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
    }
}
