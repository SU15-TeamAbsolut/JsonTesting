using System;
using System.Collections.Generic;

namespace JsonTesting.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }        
        public int ShippingAddressId { get; set; }
        public virtual Address ShippingAddress { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime DesiredDeliveryDate { get; set;}
        public OrderStatus OrderStatus { get; set; }
        public virtual IList<OrderRow> OrderRows { get; set; }
    }

    
}