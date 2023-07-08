using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._06._2023_Kapsulleme
{
    public class KapsullemeClass
    {
        int kapsulID;
        public int KapsulID 
        { 
            get // get yazılımda okumak(yani read işlemi) değeri okur yada listeler
            { 
                return kapsulID; 
            }
            set // set yazılımda değerin üstüne değer atar.
            {
                kapsulID = value; 
            }
        }


        public string KapsulName { get; set; }
        public string KapsulType { get; set; }
    }
}
