using AdvancedCode.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCode.Classes.C20041302
{
    public class UsingLambda : IClassRoom
    {
        /*delegate int CalculateAndWrite();
        delegate int CalculateAndWriteNumbers(int numberA, int numberB);*/

        public void RunTest()
        {
            /*
            CalculateAndWrite calculateAndWrite = () =>
            {
                return 10 + 20;
            };

            var result = calculateAndWrite();
            Console.WriteLine(result);

            CalculateAndWriteNumbers calculateAndWriteNumbers = (numberA, numberB) =>
            {
                var numberAB = numberA + numberB;

                return numberAB;
            };

            result = calculateAndWriteNumbers(30, 40);
            Console.WriteLine(result);*/

            Func<int> calculateAndWrite = () =>
            {
                return 10 + 20;
            };

            var result = calculateAndWrite();
            Console.WriteLine(result);

            Func<int, int, int> calculateNumbers = (numberA, numberB) =>
            {
                var numberAB = numberA + numberB;

                return numberAB;
            };

            result = calculateNumbers(30, 20);
            Console.WriteLine(result);
            result = calculateNumbers(50, 80);
            Console.WriteLine(result);

            Func<int, int, string> calculateAndWriteNumbers = (numberA, numberB) =>
            {
                var numberAB = numberA + numberB;

                return "The result is: " + numberAB;
            };

            CalculateAndWriteNumbers(calculateAndWriteNumbers);

            var multiplyFunc = GetMultiplyFunc();
            result = multiplyFunc(10, 8);
            Console.WriteLine("Multiply result is: " + result);
        }

        private void CalculateAndWriteNumbers(Func<int, int, string> calculateAndWriteNumbers)
        {
            var message = calculateAndWriteNumbers(20, 89);
            Console.WriteLine(message);

            message = calculateAndWriteNumbers(90, 59);
            Console.WriteLine(message);
        }

        private Func<int, int, int> GetMultiplyFunc()
        {
            Func<int, int, int> multiply = (numberA, numberB) =>
            {
                return numberA * numberB;
            };

            return multiply;
        }
    }
}
