using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._06._2023_Kalıtım_2
{
    public class Insan : Canlı
    {
        public string LastName { get; set; }
        public string Dusunme { get; set; }

        public void IseGitme()
        {
            Console.WriteLine("Burası İşe Gitme Methodu");
        }
    }
}
