using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IRSv2._0.Models
{
    public class HostsModel
    {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }

        [ForeignKey("Manager")]
        public string? ManagerID { get; set; }
        public ManagersModel Manager { get; set; }
        public virtual List<TablesModel> Sector { get; set; }
        public virtual List<ToGoOrdersModel> ToGoOrders { get; set; }

        public HostsModel()
        {
            Sector = new List<TablesModel>();
            ToGoOrders = new List<ToGoOrdersModel>();
        }
        public HostsModel(string id, string name)
        {
            ID = id;
            Name = name;
            Sector = new List<TablesModel>();
            ToGoOrders = new List<ToGoOrdersModel>();
        }
    }
}
