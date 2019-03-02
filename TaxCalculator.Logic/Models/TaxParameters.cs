using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Logic.Enums;

namespace TaxCalculator.Logic.Models
{
    public class TaxParameters
    {
        private double _incomeTaxFee;
        private double _socialContributionsFee;
        private double _lowestTaxValue;
        private double _highestTaxValue;

        public TaxParameters()
        {
            Dictionary<string, double> criteria = TaxCalculationCriteria.Rules;
            Dictionary<string, double> range = TaxRange.Rules;
            
            range.TryGetValue(TaxRangeEnum.Lowest.ToString(), out _lowestTaxValue);
            range.TryGetValue(TaxRangeEnum.Highest.ToString(), out _highestTaxValue);
            criteria.TryGetValue(TaxCriteriasEnum.IncomeTax.ToString(), out _incomeTaxFee);
            criteria.TryGetValue(TaxCriteriasEnum.SocialContributions.ToString(), out _socialContributionsFee);

        }
        public double LowRange { get => _lowestTaxValue; set => _lowestTaxValue = value; }
        public double HighRange { get => _highestTaxValue; set => _highestTaxValue = value; }
        public double IncomeTaxPercent { get => _incomeTaxFee; set => _incomeTaxFee = value; }
        public double SocialContributionsPercent { get => _socialContributionsFee; set => _socialContributionsFee = value; }
    }
}
