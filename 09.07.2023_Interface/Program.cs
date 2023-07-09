using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._07._2023_Interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            PersonelCustomer pCustomer = new PersonelCustomer();
            pCustomer.Name = "Doğukan";
            Console.WriteLine(pCustomer.Name);
            Console.ReadLine();
        }
    }
}
