using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Paths
{
    class Program
    {
        static void Main(string[] args)
        {
            const string path = "path.txt";

            Path3D pointList = new Path3D();

            try
            {
                Console.WriteLine("How may points you want to add in your file: ");
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine("Enter the cordinates of your [{0}] point separated by a space: ", i);
                    int[] pointCordinates = Console.ReadLine().Split(new char[] { ' ' },
                        StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                    Storage.SavePointCoordinates(path, pointCordinates);
                }
                Console.WriteLine();
                Console.WriteLine("Now I will read the cordinates of your point from the file");

                pointList = Storage.LoadPointCoordinates(path);

                Console.WriteLine(pointList);
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("You must add a number");
            }

            catch (OverflowException)
            {
                Console.Error.WriteLine("You must add a valid integer number");
            }

            catch (ArgumentOutOfRangeException)
            {
                Console.Error.WriteLine("You must add a number");
            }

            catch (ArgumentException)
            {
                Console.Error.WriteLine("You must add a number");
            }
        }
    }
}
