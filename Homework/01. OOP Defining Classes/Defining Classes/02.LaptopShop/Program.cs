using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop asus = new Laptop("Asus X550jk", 1569, new Battery("Li - ION", 4), "Asus", "Intel Core i7-4710HQ (4-ядрен, 2.50 - 3.50 GHz, 6MB кеш)", 8, "NVIDIA GeForce GTX 850M (2GB DDR3)", "1TB HDD (5400 оборотa/минута) + 128 SSD", "15.6-инчов (39.62 см.) - 1366x768, матов");
            Laptop apple = new Laptop("1kg Qbalki", 1499.99, new Battery("mnogo zle", 2), "Apple");

            Console.WriteLine(asus);
            Console.WriteLine(apple);
        }
    }
}
