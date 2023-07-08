using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._06._2023_Class
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.name = "Doğukan";
            //Console.WriteLine(person.name);


            Person1 person1 = new Person1();
            person1.Id = 1;
            person1.PersonName = "Ali Veli";
            Console.WriteLine(person1.PersonName);

            //Console.WriteLine(person1.Id);
            //person1.Test();

            //Person person = new Person("Berk");
            //Console.WriteLine(person.Name);

            Console.ReadLine();
        }
    }

    /// <summary>
    /// Bu class yapısı yanlıştır. Çünkü her class yeni bir class olarak oluşturulmalıdır(Ayrı bir sayfada oluşturulmlıdır.). Bunun nedeni ise kod kabalığı olmaması için.
    /// </summary>
    public class Person
    {
        //public Person()
        //{

        //}
        //public Person(string _name)
        //{
        //    Name = _name;
        //}

        //public string Name { get; set; }

        //public string name;
        //public int age;

        //public void Deneme()
        //{

        //}
    }
}
