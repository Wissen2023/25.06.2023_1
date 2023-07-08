using _08._07._2023_AbstractClass.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._07._2023_AbstractClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.KM();
            car.KM1(1);
            car.Marka();

            car.CarID = 2;

            Console.WriteLine(car.CarID);


            //Abstract yapısı newlenemez
            //ACar aCar = new ACar();
            //aCar.KM1(1);

            Console.ReadLine();
        }
    }
}
