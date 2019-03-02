using System;
using TaxCalculator.Helpers;
using TaxCalculator.Logic.Models;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            CalculateSalary();
            Console.WriteLine("Press any key to exit!");
            Console.ReadLine();
        }

        public static void CalculateSalary()
        {
            double input = 0.0;
            SalaryModel salary = new SalaryModel();
            EmployeeTaxes taxes = new EmployeeTaxes();
            string choice = "y";

            do
            {
                Console.WriteLine("Please input salary");
                Double.TryParse(Console.ReadLine(), out input);
                salary = taxes.Calculate(input);
                Console.WriteLine("Salary:\n\tGross: {0}\n\tFees: {1}\n\tNet: {2}", salary.Gross, salary.Fees, salary.Net);
                Console.WriteLine("Would you like to calculate another? (Y/N)");
                choice = Console.ReadLine();
            }
            while (input <= 0.0 || choice.ToLower() == "y");
        }
    }
}
