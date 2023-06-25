using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._06._2023_Virtual
{
    public class Program
    {
        static void Main(string[] args)
        {
            Insan ınsan = new Insan();
            ınsan.Yaz("İnsan Classı");

            Base base1 = new Base();
            base1.Yaz("Base Classı");

            Console.ReadLine();
        }
    }
}
