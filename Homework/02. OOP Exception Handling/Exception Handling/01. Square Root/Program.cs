using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01.Square_Root
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            try
            {

                double sqrt = SquareRoot.Sqrt(number);

                Console.WriteLine("The square root of {0} is {1:f4}.", number, sqrt);
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
            }
            catch (OverflowException oex)
            {
                Console.WriteLine(oex.Message);
            }
            catch (ArgumentOutOfRangeException aex)
            {
                Console.WriteLine(aex.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}
