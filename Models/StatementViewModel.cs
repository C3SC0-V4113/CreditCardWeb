namespace CreditCardWeb.Models
{
    public class StatementViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CardNumber { get; set; }
        public decimal CurrentBalance { get; set; }
        public decimal CreditLimit { get; set; }
        public decimal AvailableBalance { get; set; }
        public decimal BonificableInterest { get; set; }
        public decimal MinimumPayment { get; set; }
        public decimal currentMonthTotal { get; set; }
        public decimal previousMonthTotal { get; set; }
        public List<PurchaseViewModel> Purchases { get; set; }
    }
}
