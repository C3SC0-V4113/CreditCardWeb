using CreditCardWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CreditCardWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public IndexModel(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public List<CreditCardViewModel> CreditCards { get; set; }

        public async Task OnGetAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7167/api/CreditCard");
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                CreditCards = JsonConvert.DeserializeObject<List<CreditCardViewModel>>(jsonResponse);
            }
        }
    }
}
