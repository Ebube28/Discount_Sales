using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testrun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int denominator = 5;
            int numerator = ++denominator;
            Console.WriteLine(numerator);
        }   
    }
}
