using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class PriorityOrder : Order
    {
        public DateTime DesiredDeliveryDate { get; set; }

        public DeliveryTime DesiredDeliveryTime { get; set; }

        public PriorityOrder() : base()
        {
            DesiredDeliveryDate = DateTime.Now;
            DesiredDeliveryTime = DeliveryTime.Range9To11;
        }

        public PriorityOrder(string customerName, OrderStatus status, DateTime creationDate, List<Item> items, DateTime desiredDeliveryDate, DeliveryTime desiredDeliveryTime) : base(customerName, status, creationDate, items)
        {
            DesiredDeliveryDate = desiredDeliveryDate;
            DesiredDeliveryTime = desiredDeliveryTime;
        }
    }
}
