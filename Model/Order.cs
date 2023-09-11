using ProductOrderApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrderApp.Model
{
    internal class Order
    { 
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<LineItem> LineItems { get; set; } = new List<LineItem>();

        public Order(int id, DateTime date, List<LineItem> lineitems)
        {
            Id = id;
            Date = date;
            LineItems = lineitems;
        }
        public double CalculateOrderPrice()
        {
            double totalprice = 0;
            foreach (LineItem lineItem in LineItems)
            {
                totalprice += lineItem.CalculateLineItemCost();
            }
            return totalprice;


        }
    }
}
