using System.ComponentModel.DataAnnotations;

namespace IRSv2._0.Models
{
    public class ToGoOrdersModel
    {
        [Key]
        public string ID { get; set; }
        public double Price { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverAddress { get; set; }
        public int ReceiverPhoneNumber { get; set; }
        public virtual List<CooksModel> Cooks { get; set; }
        public virtual List<ProductsModel> Products { get; set; }

        public ToGoOrdersModel()
        {
            Cooks = new List<CooksModel>();
            Products = new List<ProductsModel>();

        }
        public ToGoOrdersModel(string id, double price, string receierName, string receiverAddress, int receiverPhoneNumber)
        {
            ID = id;
            Price = price;
            ReceiverName = receierName;
            ReceiverAddress = receiverAddress;
            ReceiverPhoneNumber = receiverPhoneNumber;
            Cooks = new List<CooksModel>();
            Products = new List<ProductsModel>();

        }
    }
}