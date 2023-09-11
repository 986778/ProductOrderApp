using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrderApp.Model
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountPercent { get; set; }

        public Product(int id, string name, double price, double discountPercent)
        {
            Id = id;
            Name = name;
            Price = price;
            DiscountPercent = discountPercent;
        }
        public double CalculateDiscountedPrice()
        {
            double discountAmount = Price * DiscountPercent;
            return Price - discountAmount;
        }

       // public string Tostring(int id, string name, double price, double discountPercent)
       // {
         //   return $"Id: {id}\n; Name: {name}\n, Price: {price}\n, DiscountPercent: {discountPercent}";


        //}
    }
}
