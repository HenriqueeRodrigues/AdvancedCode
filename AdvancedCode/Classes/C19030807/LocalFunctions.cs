using AdvancedCode.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCode.Classes.C19030807
{
    public class LocalFunctions : IClassRoom
    {
        public void RunTest()
        {
            var totalValueCalculated = CalculateTax(1500);
            Console.WriteLine("Total Value with Tax is: " + totalValueCalculated.ToString("c2"));

            totalValueCalculated = CalculateTax(500);
            Console.WriteLine("Total Value with Tax is: " + totalValueCalculated.ToString("c2"));

            totalValueCalculated = CalculateTax(2500);
            Console.WriteLine("Total Value with Tax is: " + totalValueCalculated.ToString("c2"));

            decimal CalculateTax(decimal totalValue)
            {
                if (totalValue < 1000)
                {
                    return totalValue + 5;
                }
                else
                {
                    return totalValue + 10;
                }
            }
        }

        public void AnotherRunTest()
        {
            
        }
    }
}
