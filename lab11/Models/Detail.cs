namespace lab11.Models
{
    public class Detail
    {
        public int DetailId { get; set; }
        public int Amount { get; set; }
        public float Price { get; set; }
        public float Subtotal { get; set; }

        //Product
        public int ProductId { get; set; }
        public Product Product { get; set; }

        //Invoice 
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
    }
}
