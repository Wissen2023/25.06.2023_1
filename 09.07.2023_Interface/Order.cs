using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._07._2023_Interface
{
    public class Order
    {
        public int Number { get; set; }
        public double Price { get; set; }

        // Buda "1" kısmı
        public Customer Customer { get; set; }
    }
}
