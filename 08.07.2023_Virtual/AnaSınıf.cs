using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._07._2023_Virtual
{
    public class AnaSınıf
    {
        public int Id { get; set; }

        public virtual void AnaSınıfMethod(string mtn)
        {
            Console.WriteLine(mtn);
        }
    }
}
