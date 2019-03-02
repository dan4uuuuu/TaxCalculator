using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Logic.Interface;

namespace TaxCalculator.Logic.Models
{
    /// <summary>
    /// Income tax class.
    /// </summary>
    public class IncomeTax : ICalculateTax
    {
        private TaxParameters _parameters = new TaxParameters();
        public double Calculate(double salary)
        {
            return (salary - _parameters.LowRange) * _parameters.IncomeTaxPercent;
        }
    }
}
