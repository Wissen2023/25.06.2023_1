using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._07._2023_Virtual_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Insan ınsan = new Insan();
            //ınsan.InsanMethod("Bu methoda programcs de yazı yazdık");

            VirtualInsan virtualInsan = new VirtualInsan();
            virtualInsan.InsanMethod("Bu methoda programcs de yazı yazdık");

            Console.ReadLine();
        }
    }
}
