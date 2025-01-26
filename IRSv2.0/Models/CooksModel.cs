using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IRSv2._0.Models
{
    public class CooksModel
    {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }

        [ForeignKey("Manager")]
        public string? ManagerID { get; set; }
        public ManagersModel Manager { get; set; }

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
