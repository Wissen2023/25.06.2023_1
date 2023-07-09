using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._07._2023_Interface
{
    public class Customer
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public double CreditRating { get; set; }

        // List çok kısmı
        public List<Order> Orders { get; set; }
    }
}
