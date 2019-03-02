using System.Collections.Generic;
using TaxCalculator.Logic.Enums;

namespace TaxCalculator.Logic.Models
{
    /// <summary>
    /// Criteria percentages by which all fees are being calculated
    /// </summary>
    public static class TaxCalculationCriteria
    {
        private static Dictionary<string, double> _Rules = new Dictionary<string, double>()
        {
            { TaxCriteriasEnum.IncomeTax.ToString(), 0.1 },
            { TaxCriteriasEnum.SocialContributions.ToString(), 0.15 }
        };
        
        public static Dictionary<string, double> Rules { get => _Rules; set => _Rules = value; }        
    }
}
