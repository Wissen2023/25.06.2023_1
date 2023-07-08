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
            urun.Id = 3;

            Console.WriteLine(urun.Ad);
            Console.WriteLine(urun.Id);

            //Musteri musteri = new Musteri();
            //musteri.Ad = "Müşteri 1";
            //Console.WriteLine(musteri.Ad);

            Console.ReadLine();
        }
    }
}
