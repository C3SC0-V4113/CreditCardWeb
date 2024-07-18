namespace CreditCardWeb.Models
{
    public class TransactionViewModel
    {
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }
        public decimal? Charge { get; set; }
        public decimal? Credit { get; set; }
    }
}
