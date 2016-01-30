using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pesho = new Person("Pesho", 20, "Pesho@gmail.com");
            Person gosho = new Person("Gosho", 18);
            Console.WriteLine(pesho);
            Console.WriteLine(gosho);
        }
    }
}
