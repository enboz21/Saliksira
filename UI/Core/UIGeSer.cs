using Entity.DTOs;
using Newtonsoft.Json;
using System.Net.Http;
using UI.Core.Interface;

namespace UI.Core
{
    internal class UIGeSer : IUIGeSer
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://localhost:44352/api/Ge";
        public UIGeSer(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<GeDTO>> GetAll()
        {
            List<GeDTO> GE;
            HttpResponseMessage response = await _httpClient.GetAsync(BaseUrl);
            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                GE = JsonConvert.DeserializeObject<List<GeDTO>>(jsonResponse);
                return GE;
            }
            else
            {
                string errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"cinsiyetler çekilirken hata oluştu: {response.StatusCode} - {errorContent}");
            }
        }
    }
}
