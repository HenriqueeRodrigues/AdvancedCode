using AdvancedCode.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCode.Classes.C20041301
{
    public class UsingLambda : IClassRoom
    {
        /*delegate void WriteSomething();
        delegate void CalculateAndWriteNumbers(int numberA, int numberB);*/
        
        public void RunTest()
        {
            /*
            WriteSomething writeSomething = () =>
            {
                Console.WriteLine("This is a message!");
                Console.WriteLine("This is a second message!");
                Console.WriteLine("This is another message!");
            };

            CalculateAndWriteNumbers calculateAndWriteNumbers = (numberA, numberB) =>
            {
                var result = numberA + numberB;
                Console.WriteLine("Sum operation result: " + result);
            };*/

            Action writeSomething = () =>
            {
                Console.WriteLine("This is a message!");
                Console.WriteLine("This is a second message!");
                Console.WriteLine("This is another message!");
            };

            writeSomething();

            Action<int, int> calculateAndWriteNumbers = (numberA, numberB) =>
            {
                var result = numberA + numberB;
                Console.WriteLine("Sum operation result is " + result);
            };

            CalculateNumbers(calculateAndWriteNumbers);
        }

        private void CalculateNumbers(Action<int, int> calculateAndWriteNumbers)
        {
            calculateAndWriteNumbers(10, 20);
            calculateAndWriteNumbers(30, 40);
            calculateAndWriteNumbers(40, 40);
            calculateAndWriteNumbers(10, 50);
        }
    }
}
