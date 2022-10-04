namespace First_Project.Models
{
    public class Totalinvoice
    {

        public Order order { get; set; }
        public Product product { get; set; }
        public OrderProduct orderProduct { get; set; }
    }
}
