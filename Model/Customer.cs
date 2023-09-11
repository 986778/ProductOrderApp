using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrderApp.Model
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();

        public Customer(int id, string name, List<Order> orders) 
        {
            Id = id;
            Name = name;
            Orders = orders;
        }
        public string DataCustomer(int id, string name, List<Order> orders)
        {
            return (id + "_" + name + "_" + orders) ;
        }
    }
    
}
