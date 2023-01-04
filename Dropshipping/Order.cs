namespace DropShipping
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int PaymentId { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderStatus { get; set; }
        public int OrderPrice { get; set; }
        public DateTime ShippingDate { get; set; }
        public int ShippingStatus { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
        public Order()
        {
            OrderDate = DateTime.Now;

        }
    }

}