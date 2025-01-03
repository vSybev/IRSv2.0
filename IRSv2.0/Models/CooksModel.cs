using System.ComponentModel.DataAnnotations;

namespace IRSv2._0.Models
{
    public class CooksModel
    {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
        public virtual List<OrdersModel> Orders { get; set; }
        public virtual List<ToGoOrdersModel> ToGoOrders { get; set; }

        public CooksModel()
        {
            Orders = new List<OrdersModel>();
            ToGoOrders = new List<ToGoOrdersModel>();
        }
        public CooksModel(string id, string name)
        {
            ID = id;
            Name = name;
            Orders = new List<OrdersModel>();
            ToGoOrders = new List<ToGoOrdersModel>();
        }
    }
}
