using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> test = new GenericList<int>(2);
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
          
            Console.WriteLine(test);
            Console.WriteLine(test[3]);
            Console.WriteLine(test.IndexOf(121));
            test.RemoveAt(2);
            Console.WriteLine(test);
            Console.WriteLine(test.Count);
            Console.WriteLine("Max: " + test.Max());
            Console.WriteLine("Min: " + test.Min());
           
        }
    }
}
