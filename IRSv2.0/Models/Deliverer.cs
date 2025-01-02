﻿using System.ComponentModel.DataAnnotations;

namespace IRSv2._0.Models
{
    public class Deliverer
    {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
        public virtual List<ToGoOrder> ToGoOrders { get; set; }

        public Deliverer()
        {
            ToGoOrders = new List<ToGoOrder>();
        }
        public Deliverer(string id, string name)
        {
            ID = id;
            Name = name;
            ToGoOrders = new List<ToGoOrder>();
        }
    }
}