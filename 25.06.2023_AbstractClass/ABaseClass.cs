using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._06._2023_AbstractClass
{
    public abstract class ABaseClass
    {
        public int ID { get; set; }

        public void Yaz()
        {
            Console.WriteLine("Burası abstract classtan gelen Yaz methodu");
        }
        //Abstarct method
        public abstract int mul(int i);
    }
}
