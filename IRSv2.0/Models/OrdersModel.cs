using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using IRSv2._0.Models.Enums;


namespace IRSv2._0.Models
{
    public class OrdersModel
    {
        [Key]
        public string ID { get; set; }
        public double Price { get; set; }

        [ForeignKey("Waiter")]
        public string? WaiterID { get; set; }
        public WaitersModel Waiter { get; set; }

        [ForeignKey("Table")]
        public string? TableID { get; set; }
        public TablesModel Table { get; set; }

        public OrderStatus Status { get; set; }
        public virtual List<ProductsModel> Products { get; set; }
        public virtual List<CooksModel> Cooks { get; set; }

        public OrdersModel()
        {
            Products = new List<ProductsModel>();
            Cooks = new List<CooksModel>();
        }

        public OrdersModel(string id, double price, string waiterID, string tableID)
        {
            ID = id;
            Price = price;
            WaiterID = waiterID;
            TableID = tableID;
            Products = new List<ProductsModel>();
            Cooks = new List<CooksModel>();
        }

        //public string CookNames => string.Join(", ", Cooks.Select(c => c.Name));
    }
}