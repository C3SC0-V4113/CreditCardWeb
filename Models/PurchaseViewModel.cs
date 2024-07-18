namespace CreditCardWeb.Models
{
    public class PurchaseViewModel
    {
        public int PurchaseId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
