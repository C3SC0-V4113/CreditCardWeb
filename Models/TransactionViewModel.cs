namespace CreditCardWeb.Models
{
    public class TransactionViewModel
    {
        public int TransactionId { get; set; }
        public int CreditCardId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
