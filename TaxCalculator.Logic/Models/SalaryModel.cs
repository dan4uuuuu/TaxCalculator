using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.Logic.Models
{
    /// <summary>
    /// Salary information model.
    /// </summary>
    public class SalaryModel
    {
        public SalaryModel()
        {

        }
        public double Net { get; set; }
        public double Gross { get; set; }
        public double Fees { get; set; }
    }
}
