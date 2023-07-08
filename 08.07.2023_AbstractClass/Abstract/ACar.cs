using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._07._2023_AbstractClass
{
    public abstract class ACar
    {
        public int CarID { get; set; }

        public void KM()
        {
            Console.WriteLine("Absract class içindeki method");
        }
        public void Marka()
        {
            Console.WriteLine("Marka ismi buradadır");
        }

        public abstract void KM1(int carID);
    }
}
