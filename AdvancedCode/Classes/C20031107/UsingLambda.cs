using AdvancedCode.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCode.Classes.C20031107
{
    public class UsingLambda : IClassRoom
    {
        delegate decimal CalculateNumbers(params decimal[] numbers);

        public void RunTest()
        {
            CalculateNumbers calculateNumbers = (numbers) =>
            {
                var result = decimal.Zero;

                foreach(var number in numbers)
                {
                    result += number;
                }

                return result;
            };

            var sumNumbers = calculateNumbers(10, 20, 30);
            Console.WriteLine("The result is: " + sumNumbers);

            sumNumbers = calculateNumbers(50, 80);
            Console.WriteLine("The result is: " + sumNumbers);

            sumNumbers = calculateNumbers(10, 10, 10, 15, 15);
            Console.WriteLine("The result is: " + sumNumbers);
        }
    }
}
