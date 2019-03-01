using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Helpers;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = 0.0;
            Double.TryParse(Console.ReadLine(), out input);
            var tax = new Tax();
            var result = tax.Calculate(input);

            Console.ReadLine();
        }
    }
}
