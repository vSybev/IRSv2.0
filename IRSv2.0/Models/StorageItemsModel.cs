using System.ComponentModel.DataAnnotations;

namespace IRSv2._0.Models
{
    public class StorageItemsModel
    {
          
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }

        public StorageItemsModel() { }
        public StorageItemsModel(string id, string name, int count)
        {
            ID = id;
            Name = name;
            Count = count;
        }
    
}
}