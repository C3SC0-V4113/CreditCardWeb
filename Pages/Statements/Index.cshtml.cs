using CreditCardWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Net.Http;

namespace CreditCardWeb.Pages.Statements
{
    public class IndexModel : PageModel
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public IndexModel(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public StatementViewModel Statement { get; set; }
        public decimal TotalCurrentMonth { get; set; }
        public decimal TotalPreviousMonth { get; set; }

        public async Task OnGetAsync(int id)
        {

            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:7167/api/Statement/{id}");

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                Statement = JsonConvert.DeserializeObject<StatementViewModel>(jsonResponse);
            }

            //var currentMonthResponse = await client.GetAsync($"https://localhost:7167/api/Statement/{id}/current-month");
            //if (currentMonthResponse.IsSuccessStatusCode)
            //{
            //    var jsonResponse = await currentMonthResponse.Content.ReadAsStringAsync();
            //    TotalCurrentMonth = decimal.Parse(jsonResponse);
            //}

            //var previousMonthResponse = await client.GetAsync($"https://localhost:7167/api/Statement/{id}/previous-month");
            //if (previousMonthResponse.IsSuccessStatusCode)
            //{
            //    var jsonResponse = await previousMonthResponse.Content.ReadAsStringAsync();
            //    TotalPreviousMonth = decimal.Parse(jsonResponse);
            //}

        }
    }
}
