using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._06._2023_Kalıtım_2
{
    public class Hayvan : Canlı
    {
        public string TailCount { get; set; }
        public bool Solunum { get; set; }

        public void Avlanma()
        {
            Console.WriteLine("Burası Avlanma Methodu");
        }
    }
}
