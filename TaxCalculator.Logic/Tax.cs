using System.Collections.Generic;
using TaxCalculator.Logic.Enums;
using TaxCalculator.Logic.Interface;
using TaxCalculator.Logic.Models;

namespace TaxCalculator.Helpers
{
    public class Tax : ICalculateTaxes
    {
        public Tax()
        {

        }
        public Salary Calculate(double salary)
        {
            Salary result = new Salary();
            result.Gross = salary;
            Dictionary<string, double> criteria = TaxCalculationCriteria.Rules;
            Dictionary<string, double> range = TaxRange.Rules;

            double incomeTaxFee = 0;
            double socialContributionsFee = 0;
            double lowestTaxValue = 0;
            double highestTaxValue = 0;
            range.TryGetValue(TaxRangeEnum.Lowest.ToString(), out lowestTaxValue);
            range.TryGetValue(TaxRangeEnum.Highest.ToString(), out highestTaxValue);
            criteria.TryGetValue(TaxCriteriasEnum.IncomeTax.ToString(), out incomeTaxFee);
            criteria.TryGetValue(TaxCriteriasEnum.SocialContributions.ToString(), out socialContributionsFee);

            if (salary > lowestTaxValue)
            {
                result.Fees += CalculateIncomeFee(salary, lowestTaxValue, incomeTaxFee);
                result.Fees += CalculateSocialContributionsFee(salary, lowestTaxValue, highestTaxValue, socialContributionsFee);
            }

            result.Net = result.Gross - result.Fees;
            return result;
        }

        private double CalculateIncomeFee(double salary, double lowestTaxValue, double incomeTaxFee)
        {
            return (salary - lowestTaxValue) * incomeTaxFee;
        }

        private double CalculateSocialContributionsFee(double salary, double lowestTaxValue, double highestTaxValue, double socialContributionsFee)
        {
            if(salary > highestTaxValue)
            {
                return (highestTaxValue - lowestTaxValue) * socialContributionsFee;
            }
            else
            {
                return (salary - lowestTaxValue) * socialContributionsFee;
            }
        }
    }
}
