using System.ComponentModel.DataAnnotations;

namespace IRSv2._0.Models
{
    public class WaitersModel
    {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
        public bool OnWork { get; set; }
        public virtual List<TablesModel> Sector { get; set; }
        public virtual List<OrdersModel> Orders { get; set; }

        public WaitersModel()
        {
            Sector = new List<TablesModel>();
            Orders = new List<OrdersModel>();
        }

        public WaitersModel(string id, string name, bool onWork)
        {

            ID = id;
            Name = name;
            OnWork = onWork;
            Sector = new List<TablesModel>();
            Orders = new List<OrdersModel>();
        }
    }
}