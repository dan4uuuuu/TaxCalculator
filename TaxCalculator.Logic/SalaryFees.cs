using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Logic.Interface;
using TaxCalculator.Logic.Models;

namespace TaxCalculator.Logic
{
    public class SalaryFees
    {
        public SalaryModel Calculate(double salary)
        {
            SalaryModel result = new SalaryModel();
            Taxes taxes = new Taxes();
            result.Gross = salary;
            foreach (var item in taxes.ApplicableTaxes)
            {
                Type type = Type.GetType(item.Name);
                MethodInfo methodInfo = type.GetMethod(item.MethodToInvoke);
                if (methodInfo != null)
                {
                    ParameterInfo[] parameters = methodInfo.GetParameters();
                    if (parameters.Length != 0)
                    {
                        object classInstance = Activator.CreateInstance(type, null);
                        object[] parametersArray = new object[] { salary };
                        double fees = 0.0;
                        Double.TryParse(methodInfo.Invoke(classInstance, parametersArray).ToString(), out fees);
                        result.Fees += fees;
                    }
                    result.Net = salary - result.Fees;
                }            
            }
            return result;
        }
    }
}
