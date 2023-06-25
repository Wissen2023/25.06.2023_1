using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._06._2023_Enum
{
    public class Program
    {
        static void Main(string[] args)
        {
            EnumClass enumClass = new EnumClass();
            Console.WriteLine(enumClass.days[0].ToString());
            Console.ReadLine();
        }
    }
}
