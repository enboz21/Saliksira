using Newtonsoft.Json;
using System.Net.Http;
using System.Windows.Controls;
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
    }
}
