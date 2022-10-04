using System.ComponentModel.DataAnnotations.Schema;

namespace First_Project.Models
{
    public class sales
    {
        public Store store { get; set; }    
        public Product product { get; set; }
        public Order order { get; set; }    
        [NotMapped]
        public OrderProduct orderProduct { get; set; }    
    }
}
