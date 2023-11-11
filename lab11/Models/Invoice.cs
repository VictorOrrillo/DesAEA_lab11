namespace lab11.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public DateTime DateTime { get; set; }
        public string InvoiceNumber { get; set; }
        public float Total { get; set; }

        //Customer
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
