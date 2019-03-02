using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Logic.Interface;

namespace TaxCalculator.Logic.Models
{
    /// <summary>
    /// Tax list model
    /// </summary>
    public class Taxes : ITax
    {
        private static List<Taxes> _ApplicableTaxes = new List<Taxes>()
        {
            new Taxes(){ MethodToInvoke = "Calculate", Name = "TaxCalculator.Logic.Models.IncomeTax" },
            new Taxes(){ MethodToInvoke = "Calculate", Name = "TaxCalculator.Logic.Models.SocialContributionsTax" }
        };

        public List<Taxes> ApplicableTaxes { get => _ApplicableTaxes; set => _ApplicableTaxes = value; }

        public string Name { get; set; }
        public string MethodToInvoke { get; set; }
    }
}
