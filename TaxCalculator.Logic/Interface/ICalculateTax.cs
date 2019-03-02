using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Logic.Models;

namespace TaxCalculator.Logic.Interface
{
    /// <summary>
    /// Calculate concrete tax.
    /// </summary>
    public interface ICalculateTax
    {
        double Calculate(double salary);
    }
}
