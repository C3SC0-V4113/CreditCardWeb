namespace CreditCardWeb.Models
{
    public class PaymentViewModel
    {
        public int PaymentId { get; set; }
        public int CreditCardId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
    }
}
