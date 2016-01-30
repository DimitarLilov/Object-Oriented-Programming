using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Generic_List_Version
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> test = new GenericList<int>();

            Console.WriteLine();

            test.Add(123);
            test.Add(1234);
            test.Add(12345);
            test.Add(123456);

            Console.WriteLine(test);
            test.Remove(2);
            test.Insert(11, 2);
            test.Insert(666, 0);
            Console.WriteLine(test);
            Console.WriteLine(test.Find(11));
            Console.WriteLine(test.Contains(1234));
            test.Add(-100);
            Console.WriteLine(test.Min());

            Type type = test.GetType();
            object[] allAttributes =
                type.GetCustomAttributes(false)
                .Where(x => x.GetType() == typeof(VersionAttribute))
                .ToArray();

            foreach (VersionAttribute attr in allAttributes)
            {
                Console.WriteLine(attr.Major + "." + attr.Minor);
            }
        }
    }
}
