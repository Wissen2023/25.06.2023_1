using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._07._2023_Virtual_2
{
    public class VirtualInsan : Insan
    {
        public override void InsanMethod(string yazi)
        {
            base.InsanMethod("Override edilen kısım");
        }
    }
}
