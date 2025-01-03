using IRSv2._0.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace IRSv2._0.Models
{
    public class ProductsModel
    {

        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public ProductAvailability Availability { get; set; }
        public virtual List<StorageItemsModel> Items { get; set; }

        public ProductsModel()
        {
            Items = new List<StorageItemsModel>();
        }
        public ProductsModel(string id, string name, string discripion, string type, double price, ProductAvailability availability)
        {
            ID = id;
            Name = name;
            Description = discripion;
            Type = type;
            Price = price;
            Availability = availability;
            Items = new List<StorageItemsModel>();
        }
    }
}