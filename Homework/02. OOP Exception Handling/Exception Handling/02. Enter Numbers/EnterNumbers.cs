using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Enter_Numbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
            int counter = 10;
            int start = 1;
            int end = 100;
            List<int> numbers = new List<int>();
            while (counter >= 1)
            {
                Console.WriteLine("Enter a number in range [{0}...{1}]",start,end);
                int number = 0;
                try
                {
                    number = ReadNumber(start, end);
                    numbers.Add(number);
                    start = number;
                    counter--;
                }
                catch (ArgumentNullException nullex)
                {
                    Console.Error.WriteLine(nullex.Message);
                }
                catch (FormatException fex)
                {
                    Console.Error.WriteLine(fex.Message);
                }
                catch (ArgumentOutOfRangeException outOfRange)
                {
                    Console.Error.WriteLine(outOfRange.Message);
                }
                catch (OverflowException ofex)
                {
                    Console.Error.WriteLine(ofex.Message);
                }
                catch (ApplicationException ae)
                {
                    Console.Error.WriteLine(ae.Message);
                    numbers.Add(number);
                    counter = 0;
                }
            }
            Console.WriteLine("{{ {0} }}", string.Join(", ", numbers));
        }
        private static int ReadNumber(int start, int end)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException();
            }
            int number = int.Parse(input);
            if (number <= start || number >= end)
            {
                throw new ArgumentOutOfRangeException();
            }
            return number;
        }
    }
}
