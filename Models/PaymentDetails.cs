namespace ProvaPub.Models
{
    public class PaymentDetails
    {
        public string CardNumber { get; set; }
        public DateTime? ExpiryDate { get; set; }

        public int CVV { get; set; }
    }
}
