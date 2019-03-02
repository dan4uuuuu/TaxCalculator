using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Logic.Interface;

namespace TaxCalculator.Logic.Models
{
    /// <summary>
    /// Social contributions class.
    /// </summary>
    public class SocialContributionsTax : ICalculateTax
    {
        private TaxParameters _parameters = new TaxParameters();

        public double Calculate(double salary)
        {
            if (salary > _parameters.HighRange)
            {
                return (_parameters.HighRange - _parameters.LowRange) * _parameters.SocialContributionsPercent;
            }
            else
            {
                return (salary - _parameters.LowRange) * _parameters.SocialContributionsPercent;
            }
        }
    }
}
