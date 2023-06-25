using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._06._2023_Kalıtım_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hayvan hayvan = new Hayvan();
            hayvan.Avlanma();
            hayvan.Beslenme();
            hayvan.Solunum = false;

            Console.WriteLine(hayvan.Solunum);

            Insan ınsan = new Insan();
            ınsan.NefesAlma();

            Canlı canlı = new Canlı();
            canlı.Uyuma();

            Console.ReadLine();
        }
    }
}
