using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._06._2023_1
{
    public class Wissen
    {
        //Sadece bu class içinde erişilir
        private void Deneme()
        {

        }

        //public her yerden bu methoda erişilir
        public void Deneme2()
        {

        }

        //Bu classta ve bundan türeyen classta kullanılır.
        protected void Deneme3()
        {

        }

        //Bu method "25.06.2023_1" projesi içinde her yerden erişim alabilir.
        internal void Deneme4()
        {

        }

        //Bu method protected ve internal karışımıdır.
        protected internal void Deneme5()
        {

        }
    }
}
