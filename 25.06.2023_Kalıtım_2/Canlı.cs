using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._06._2023_Kalıtım_2
{
    public class Canlı
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int FootCount { get; set; }
        public int HandCount { get; set; }
        public string EyeColor { get; set; }


        public void NefesAlma()
        {
            Console.WriteLine("Burası Nefes Alma Methodu");
        }

        public void Beslenme()
        {
            Console.WriteLine("Burası Beslenme Methodu");
        }

        public void Uyuma()
        {
            Console.WriteLine("Burası Uyuma methodu");
        }
    }
}
