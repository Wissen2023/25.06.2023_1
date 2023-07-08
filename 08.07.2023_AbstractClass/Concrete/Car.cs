using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._07._2023_AbstractClass.Concrete
{
    public class Car : ACar
    {
        public override void KM1(int carID)
        {
            Console.WriteLine("Burası car classı içindeki km1 methodu");
        }
    }
}
