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
        [ForeignKey("Order")]
        public string OrderId { get; set; }
        public virtual OrdersModel Order { get; set; }

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