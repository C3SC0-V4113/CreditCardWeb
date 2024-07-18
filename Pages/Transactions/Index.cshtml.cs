using CreditCardWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace CreditCardWeb.Pages.Transactions
{
    public class IndexModel : PageModel
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public IndexModel(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public List<TransactionViewModel> Transactions { get; set; }
        public CreditCardViewModel CreditCard { get; set; }

        public async Task OnGetAsync(int id)
        {
            var client = _httpClientFactory.CreateClient("CreditCardAPI");

            var response0 = await client.GetAsync($"https://localhost:7167/api/CreditCard/{id}");

            if (response0.IsSuccessStatusCode)
            {
                var jsonResponse = await response0.Content.ReadAsStringAsync();
                CreditCard = JsonConvert.DeserializeObject<CreditCardViewModel>(jsonResponse);
            }

            var response = await client.GetStringAsync($"api/transaction/{id}");
            Transactions = JsonConvert.DeserializeObject<List<TransactionViewModel>>(response);
        }
    }
}
