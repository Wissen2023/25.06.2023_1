using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._06._2023_Kalıtım
{
    public class Program
    {
        static void Main(string[] args)
        {
            Urun urun = new Urun();
            urun.Ad = "Bu müşteri ad kısmından gelen ad";
            Console.WriteLine(urun.Ad);
            Console.ReadLine();
        }
    }
}
