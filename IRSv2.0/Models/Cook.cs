using System.ComponentModel.DataAnnotations;

namespace IRSv2._0.Models
{
    public class Cook
    {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<ToGoOrder> ToGoOrders { get; set; }

        public Cook()
        {
            Orders = new List<Order>();
            ToGoOrders = new List<ToGoOrder>();
        }
        public Cook(string id, string name)
        {
            ID = id;
            Name = name;
            Orders = new List<Order>();
            ToGoOrders = new List<ToGoOrder>();
        }
    }
}
