using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._06._2023_Interface
{
    public interface IBaseInterface
    {
        string Name { get; set; }
        void Yaz();
        string Yaz2(string metin);




        //CRUD İşlemleri

        //Create -> Yeniden oluşturma 
        //Read -> Listeleme
        //Edit -> Güncelleme
        //Delete -> Silme
    }
}
