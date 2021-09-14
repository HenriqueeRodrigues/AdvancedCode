using AdvancedCode.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCode.Classes.C20031103
{
    public class UsingDelegate : IClassRoom
    {
        delegate double Operation(double numberA, double numberB);

        private double Sum(double numberA, double numberB)
        {
            return numberA + numberB;
        }

        private double Divide(double numberA, double numberB)
        {
            return numberA / numberB;
        }

        private double Multiply(double numberA, double numberB)
        {
            return numberA * numberB;
        }

        private void DoOperation(Operation operation, double numberA, double numberB)
        {
            Console.WriteLine($"This is an operation {operation.Method.Name}: ");
            Console.WriteLine("Number A: " + numberA);
            Console.WriteLine("Number B: " + numberB);
            var result = operation(numberA, numberB);
            Console.WriteLine("Result: " + result);
        }

        public void RunTest()
        {
            /*Operation operation = Sum;

            var result = operation(20, 30);
            Console.WriteLine($"Sum result: {result}");

            result = operation(30, 30);
            Console.WriteLine($"Sum result: {result}");

            operation = Multiply;
            result = operation(30, 30);
            Console.WriteLine($"Multiply result: {result}");*/

            Operation operation = Sum;
            DoOperation(operation, 20, 40);

            operation = Divide;
            DoOperation(operation, 20, 2);

            DoOperation(Multiply, 40, 3);
            DoOperation(Multiply, 50, 3);
            DoOperation(Multiply, 60, 3);
            DoOperation(Multiply, 70, 3);
        }
    }
}
