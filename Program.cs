using ProductOrderApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrderApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(1, "DairyMilk", 100, 0.1);
            Product product2 = new Product(2, "Milk", 60, 0.2);
            product1.CalculateDiscountedPrice();
            product2.CalculateDiscountedPrice();
            Console.WriteLine("Calculated Discounted price for product1 is:" +product1.CalculateDiscountedPrice());
            Console.WriteLine("Calculated Discounted price for product2 is:" + product2.CalculateDiscountedPrice());

            Order order1 = new Order(101, DateTime.Now,  new List<LineItem> {new LineItem(5, 45, product1)});
            order1.CalculateOrderPrice();
            //int productId = product1.Id;
            //Console.WriteLine($"Product Id: {productId}");
            Console.WriteLine("Order price for order1 is:" + order1.CalculateOrderPrice());

            Order order2 = new Order(102, DateTime.Now, new List<LineItem> { new LineItem(6, 50, product2) });
            order2.CalculateOrderPrice();



            Customer customer1 = new Customer(1011, "Saurabh", new List<Order> { order1 });
            Console.WriteLine("Customer for customer1 is:" + customer1.DataCustomer(1011, "saurabh", new List<Order> { order1}));

            LineItem lineItem1 = new LineItem(11, 2, product1);
            Console.WriteLine("LineItemCost for lineItem1 are:" + lineItem1.CalculateLineItemCost());

            LineItem lineItem2 = new LineItem(12, 4, product2);
            Console.WriteLine("LineItemCost for lineItem2 are:"+lineItem2.CalculateLineItemCost());

            int lineitem1id = lineItem1.Id;
            int product1id = product1.Id;
            string product1name = product1.Name;
            int quantity1 = lineItem1.Quantity;
            double unitprice1 = product1.Price;
            double discountpercent1 = product1.DiscountPercent;
            double unitcostafterdiscount1 = product1.CalculateDiscountedPrice();
            double totallineitemcost1 = lineItem1.CalculateLineItemCost();
            double ordercost1 = product1.Price;

            int lineitem2id = lineItem2.Id;
            int product2id = product2.Id;
            string product2name = product2.Name;
            int quantity2 = lineItem2.Quantity;
            double unitprice2 = product2.Price;
            double discountpercent2 = product2.DiscountPercent;
            double unitcostafterdiscount2 = product2.CalculateDiscountedPrice();
            double totallineitemcost2 = lineItem2.CalculateLineItemCost();
            double ordercost2 = product1.Price;


            Console.WriteLine("======Customer Details======");
            int customerId = customer1.Id;
            string customername = customer1.Name;
            Console.WriteLine($"Customer Id:{customerId}");
            Console.WriteLine($"Customer Name:{customername}");

            Console.WriteLine("====Order Details for order1====");
            Console.WriteLine("Order No.1");
            int order1Id = order1.Id;
            DateTime dateTime1 = order1.Date;
            Console.WriteLine($"order Id:{order1Id}");
            Console.WriteLine($"Order Date:{dateTime1}");

            Console.WriteLine($"LineItemId:{lineitem1id}, ProductId:{product1id}, ProductName:{product1name}, Quantity:{quantity1}, UnitPrice:{unitprice1}, Discount%:{discountpercent1}, UnitCostAfterDiscount:{unitcostafterdiscount1}, TotalLineItemCost:{totallineitemcost1}, TotalLineItemcost/Order Cost:{ totallineitemcost1/ordercost1}");









            Console.WriteLine("=====OrderDetails for order2====");
            Console.WriteLine("Order No.2");
            int order2Id = order2.Id;
            DateTime dateTime2 = order2.Date;
            Console.WriteLine($"Order Id: {order2Id}");
            Console.WriteLine($"Order Date:{dateTime2}");

            Console.WriteLine($"LineItemId:{lineitem2id}, ProductId:{product2id}, ProductName:{product2name}, Quantity:{quantity2}, UnitPrice:{unitprice2}, Discount%:{discountpercent2}, UnitCostAfterDiscount:{unitcostafterdiscount2}, TotalLineItemCost:{totallineitemcost2}, TotalLineItemcost/Order Cost:{totallineitemcost2 / ordercost2}");















        }
    }
}
