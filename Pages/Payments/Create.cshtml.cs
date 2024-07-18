using CreditCardWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Text;

namespace CreditCardWeb.Pages.Payments
{
    public class CreateModel : PageModel
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CreateModel(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [BindProperty]
        public PaymentViewModel Payment { get; set; }
        public CreditCardViewModel CreditCard { get; set; }

        public async Task OnGetAsync(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:7167/api/CreditCard/{id}");

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                CreditCard = JsonConvert.DeserializeObject<CreditCardViewModel>(jsonResponse);
            }
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Payment.CreditCardId = id;
            var client = _httpClientFactory.CreateClient();
            var jsonContent = new StringContent(JsonConvert.SerializeObject(Payment), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:7167/api/Payment", jsonContent);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToPage("/Index");
            }

            return Page();
        }
    }
}
