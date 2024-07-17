using CreditCardWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace CreditCardWeb.Pages.Statements
{
    public class IndexModel : PageModel
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public IndexModel(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public CreditCardStatementViewModel Statement { get; set; }

        public async Task OnGetAsync(int? creditCardId)
        {
            if (creditCardId.HasValue)
            {
                var client = _httpClientFactory.CreateClient();
                var response = await client.GetAsync($"https://localhost:5001/api/creditcard/{creditCardId}");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    Statement = JsonConvert.DeserializeObject<CreditCardStatementViewModel>(jsonResponse);
                }
            }
        }
    }
}
