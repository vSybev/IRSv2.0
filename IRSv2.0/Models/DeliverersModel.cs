using System.ComponentModel.DataAnnotations;

namespace IRSv2._0.Models
{
    public class DeliverersModel
    {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
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