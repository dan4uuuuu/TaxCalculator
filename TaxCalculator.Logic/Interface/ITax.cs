using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Logic.Models;

namespace TaxCalculator.Logic.Interface
{
    /// <summary>
    /// Interface containing a list of all taxes to be applied.
    /// </summary>
    public interface ITax
    {
        List<Taxes> ApplicableTaxes { get; set; }
    }
}
