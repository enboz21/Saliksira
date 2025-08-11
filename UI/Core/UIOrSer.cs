using Entity.DTOs;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net.Http;
using UI.Core.Interface;

namespace UI.Core
{
    internal class UIOrSer : IUIOrSer
    {
        private readonly HttpClient _httpClient;
        private static string BaseUrl = Program.BaseUrl + "Or";
        public UIOrSer(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task ADD(int PtID, int DrID)
        {
            String apiUrl = BaseUrl + "/" + PtID;
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
            string jsonString = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                apiUrl = BaseUrl;
                String DATA = JsonConvert.SerializeObject(new
                {
                    hastaId = PtID,
                    doktorId = DrID
                });
                HttpContent content = new StringContent(DATA, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage respone = await _httpClient.PostAsync(apiUrl, content);
            }
        }

        public async Task<List<OrDTOE>> GetALL()
        {
            HttpResponseMessage response = await _httpClient.GetAsync(BaseUrl);

            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                List<OrDTOE> Ran = JsonConvert.DeserializeObject<List<OrDTOE>>(jsonResponse);
                return Ran;
            }
            else
            {
                return null;
            }
        }

        public async Task Delete(int OrID)
        {
            string apiUrl = BaseUrl + "/" + OrID;
            HttpResponseMessage response = await _httpClient.DeleteAsync(apiUrl);
            if (!response.IsSuccessStatusCode) 
            {
                string errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"silinecek birşey bulunamadı : {response.StatusCode} - {errorContent}");
            }
        }

        public async Task<List<OrDTOE>> GetByDrID(int DrID)
        {
            //https://localhost:44352/api/Or/by-DR/
            string apiUrl = BaseUrl + "/by-DR/" + DrID;
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                List<OrDTOE> Ran = JsonConvert.DeserializeObject<List<OrDTOE>>(jsonResponse);
                return Ran;
            }
            else
            {
                return null;
            }
        }
    }
}
