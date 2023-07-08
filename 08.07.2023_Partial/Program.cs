using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._07._2023_Partial
{
    public class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba();
            araba.ArabaId = 1;
            araba.Kaza();
            araba.TestId = 2;

            Console.WriteLine(araba.ArabaId);
            Console.WriteLine(araba.TestId);

            Console.ReadLine();
        }
    }
}
