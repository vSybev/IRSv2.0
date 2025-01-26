using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IRSv2._0.Models
{
    public class DeliverersModel
    {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }

        [ForeignKey("Manager")]
        public string? ManagerID { get; set; }
        public ManagersModel Manager { get; set; }
        public virtual List<ToGoOrdersModel> ToGoOrders { get; set; }

        public DeliverersModel()
        {
            
            ToGoOrders = new List<ToGoOrdersModel>();
        }
        public DeliverersModel(string id, string name)
        {
            ID = id;
            Name = name;
            ToGoOrders = new List<ToGoOrdersModel>();
        }
    }
}