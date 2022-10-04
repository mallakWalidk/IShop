namespace First_Project.Models
{

    public class TotalOrders
    {
        public TotalOrders ImageFile { get; set; }

        public OrderProduct OrderProduct { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        public Store Store { get; set; }
        public User User { get; set; }
        public string storeName { get; set; }
        public decimal? Summ { get; set; }
    }
}
