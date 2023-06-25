using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._06._2023_Kapsulleme
{
    public class Program
    {
        static void Main(string[] args)
        {
            KapsullemeClass kapsullemeClass = new KapsullemeClass();
            
            //Burada kapsülıdyi 1 yaparken set fonksiyonu sayesinde bunu yaptık
            kapsullemeClass.KapsulID = 1;

            //Burada Consola kapsülıdyi bastırırken get işlemini sayesinde bunu yaptık.
            Console.WriteLine(kapsullemeClass.KapsulID);



            kapsullemeClass.KapsulName = "Wissen";
            Console.WriteLine(kapsullemeClass.KapsulName);
            Console.ReadLine();
        }
    }
}
