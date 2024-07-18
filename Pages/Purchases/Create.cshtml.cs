using CreditCardWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Text;

namespace CreditCardWeb.Pages.Purchases
{
    public class CreateModel : PageModel
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CreateModel(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [BindProperty]
        public PurchaseViewModel Purchase { get; set; }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Purchase.CreditCardId = id;
            System.Diagnostics.Debug.WriteLine(id);
            var client = _httpClientFactory.CreateClient();
            var jsonContent = new StringContent(JsonConvert.SerializeObject(Purchase), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:7167/api/purchase", jsonContent);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToPage("/Index");
            }

            return Page();
        }
    }
}
