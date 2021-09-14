using AdvancedCode.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCode.Classes.C20031106
{
    public class UsingLambda : IClassRoom
    {
        delegate void WriteMessageInConsole(string message);
        delegate void CalculateAndWrite(int numberA, int numberB);

        public void RunTest()
        {
            //FirstSample();
            //SecondSample();
            SumNumbers();
            MultiplyNumbers();
        }

        private void FirstSample()
        {
            WriteMessageInConsole writeMessageInConsole = (message) => Console.WriteLine(message);

            writeMessageInConsole("This is a message for you!");
            writeMessageInConsole("This is another message for you!");
        }

        private void SecondSample()
        {
            WriteMessageInConsole writeMessageInConsole = (message) =>
            {
                Console.WriteLine("Message:");
                Console.WriteLine(message);
                Console.WriteLine("End.");
            };

            writeMessageInConsole("This is a message for you!");
            writeMessageInConsole("This is our class!");
            writeMessageInConsole("I'm a student!");
        }

        private void SumNumbers()
        {
            CalculateAndWrite writeSumResult = (numberA, numberB) =>
            {
                var result = numberA + numberB;
                Console.WriteLine("This is the result: " + result);
            };

            CalculateNumbers(writeSumResult);
        }

        private void MultiplyNumbers()
        {
            CalculateAndWrite writeSumResult = (numberA, numberB) =>
            {
                var result = numberA * numberB;
                Console.WriteLine("This is the result: " + result);
            };

            CalculateNumbers(writeSumResult);
        }

        private void CalculateNumbers(CalculateAndWrite writeSumResult)
        {
            for(int cont = 0; cont <= 10; cont++)
            {
                writeSumResult(cont, cont + 1);
            }
        }
    }
}
