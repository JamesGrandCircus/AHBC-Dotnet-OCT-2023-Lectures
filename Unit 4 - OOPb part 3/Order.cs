using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_4___OOPb_part_3
{
    internal class Order
    {
        public Order(
            int id, 
            string customerName,
            DateTime date,
            string productOrdered,
            int itemAmount,
            int quantity,
            decimal total
            )
        {
            Id = id;
            CustomerName = customerName;
            Date = date;
            ProductOrdered = productOrdered;
            ItemAmount = itemAmount;
            Quantity = quantity;
            Total = total;
        }
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime Date { get; set; }
        public string ProductOrdered { get; set; }
        public int ItemAmount { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }  
    }
}
