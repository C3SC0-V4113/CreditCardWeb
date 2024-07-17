namespace CreditCardWeb.Models
{
    public class CreditCardStatementViewModel
    {
        public int CreditCardId { get; set; }
        public string CardNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal CurrentBalance { get; set; }
        public decimal CreditLimit { get; set; }
        public decimal TotalPurchasesCurrentMonth { get; set; }
        public decimal TotalPurchasesLastMonth { get; set; }
        public decimal InterestBonificable { get; set; }
        public decimal MinimumPayment { get; set; }
        public decimal TotalAmountDue { get; set; }
        public decimal TotalAmountWithInterest { get; set; }
    }
}
