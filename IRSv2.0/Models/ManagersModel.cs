using System.ComponentModel.DataAnnotations;

namespace IRSv2._0.Models
{
    public class ManagersModel
    {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
        public virtual List<WaitersModel> Waiters { get; set; }
        public virtual List<CooksModel> Cooks { get; set; }
        public virtual List<HostsModel> Hosts { get; set; }
        public virtual List<DeliverersModel> Deliverers { get; set; }

        public ManagersModel()
        {
            Waiters = new List<WaitersModel>();
            Cooks = new List<CooksModel>();
            Hosts = new List<HostsModel>();
            Deliverers = new List<DeliverersModel>();
        }

        public ManagersModel(string id, string name)
        {
            ID = id;
            Name = name;
            Waiters = new List<WaitersModel>();
            Cooks = new List<CooksModel>();
            Hosts = new List<HostsModel>();
            Deliverers = new List<DeliverersModel>();
        }
    }
}
