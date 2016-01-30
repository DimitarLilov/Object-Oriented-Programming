using System;

namespace _01.Galactic_GPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Location home = new Location(18.037986, 28.870097, Planet.Earth);
            Console.WriteLine(home);
            Location saturn = new Location(30, 40.89, Planet.Saturn);
            Console.WriteLine(saturn);
        }
    }
}
