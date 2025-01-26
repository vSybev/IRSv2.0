using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using IRSv2._0.Models.Enums;

namespace IRSv2._0.Models
{
    public class TablesModel
    {
        [Key]
        public string ID { get; set; }
        public TableStatus Status { get; set; }

        [ForeignKey("Host")]
        public string? HostID { get; set; }
        public HostsModel Host { get; set; }

        [ForeignKey("Waiter")]
        public string? WaiterID { get; set; }
        public WaitersModel Waiter { get; set; }

        public OrdersModel Order { get; set; }



        public TablesModel()
        {
        }
        public TablesModel(string id, TableStatus status)
        {
            ID = id;
            Status = status;
            Order = new OrdersModel();
        }

        
    }
}