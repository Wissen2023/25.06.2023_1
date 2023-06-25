using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._06._2023_Interface
{
    public class Musteri : IBaseInterface
    {
        public string Name { get ; set; }

        public void Yaz()
        {
            Console.WriteLine("Burası interfaceden gelen Yaz methodu");
        }

        public string Yaz2(string metin)
        {
            throw new NotImplementedException();
        }
    }
}
