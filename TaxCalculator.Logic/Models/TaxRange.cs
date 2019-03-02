using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Logic.Enums;

namespace TaxCalculator.Logic.Models
{
    /// <summary>
    /// Ranges by which the tax fees are applied.
    /// </summary>
    public static class TaxRange
    {

        private static Dictionary<string, double> _Rules = new Dictionary<string, double>()
        {
            { TaxRangeEnum.Lowest.ToString(), 1000.0 },
            { TaxRangeEnum.Highest.ToString(), 3000.0 }
        };

        public static Dictionary<string, double> Rules { get => _Rules; set => _Rules = value; }
    }
}
