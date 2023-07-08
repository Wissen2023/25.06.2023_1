using _08._07._2023_Interface.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._07._2023_Interface
{
    public class BMW : ICar, INewInterface 
    {
        public void Km()
        {
            Console.WriteLine("Bwm aracının km'sinin hesaplandığı methoddur");
        }

        public string Marka(string marka)
        {
            throw new NotImplementedException();
        }

        public void New()
        {
            throw new NotImplementedException();
        }

        public void Old()
        {
            throw new NotImplementedException();
        }
    }
}
