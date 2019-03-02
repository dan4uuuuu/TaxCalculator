using System.Collections.Generic;
using TaxCalculator.Logic.Enums;
using TaxCalculator.Logic.Interface;
using TaxCalculator.Logic.Models;

namespace TaxCalculator.Helpers
{
    public class EmployeeTaxes : ICalculateTaxes
    {
        public EmployeeTaxes()
        {

        }
        public SalaryModel Calculate(double salary)
        {
            SalaryModel result = new SalaryModel();
            result.Gross = salary;
            TaxParameters parameters = new TaxParameters();

            if (salary > parameters.LowRange)
            {
                result.Fees += CalculateIncomeFee(salary, parameters.LowRange, parameters.IncomeTaxPercent);
                result.Fees += CalculateSocialContributionsFee(salary, parameters.LowRange, parameters.HighRange, parameters.SocialContributionsPercent);
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
