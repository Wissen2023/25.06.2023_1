using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._07._2023_Kalıtım3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Maserati maserati = new Maserati();
            maserati.YakitTipi = "Benzin";
            maserati.Logo = "M";
            maserati.UretimYili = DateTime.Now;

            Console.WriteLine(maserati.YakitTipi);
            Console.WriteLine(maserati.Logo);
            Console.WriteLine(maserati.UretimYili);

            Console.WriteLine("*********************************************");

            BMW bMW = new BMW();
            bMW.YakitTipi = "Dizel";
            bMW.Logo = "BMW";
            bMW.UretimYili = DateTime.Now;
            bMW.TekerSayisi = 4;

            Console.WriteLine(bMW.YakitTipi);
            Console.WriteLine(bMW.Logo);
            Console.WriteLine(bMW.UretimYili);
            Console.WriteLine(bMW.TekerSayisi);

            Console.ReadLine();
        }
    }
}
