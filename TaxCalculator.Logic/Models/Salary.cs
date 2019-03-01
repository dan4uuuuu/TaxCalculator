using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.Logic.Models
{
    public class Salary
    {
        public Salary()
        {

        }
        public double Net { get; set; }
        public double Gross { get; set; }
        public double Fees { get; set; }
    }
}
