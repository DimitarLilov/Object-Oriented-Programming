using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company_Hierarchy
{
    static class Utilities
    {
        public static void ValidateString(string input, string propertyName)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("{0} cannot be null or empty");
            }
        }

        public static void ValidateNumber(object input, string propertyName)
        {
            if (input as int? < 0)
            {
                throw new ArgumentException("{0} cannot be negative");
            }
        }

        public static void ValidateList<T>(List<T> list, string propertyName)
        {
            if (list == null)
            {
                throw new ArgumentNullException("{0} cannot be null", propertyName);
            }
        }
    }
}