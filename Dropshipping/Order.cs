namespace DropShipping
{
    class Order
    {
        public int Id { get; set; }
        public int CustumerId { get; set; }
        public int ProductId { get; set; }
        public int OrderDate { get; set; }
        public int OrderStatus { get; set; }
        public int OrderPrice { get; set; }
        public int ShippingDate { get; set; }
        public int ShippingStatus { get; set; }

    }
}