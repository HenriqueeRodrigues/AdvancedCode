using AdvancedCode.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCode.Classes.C20031104
{
    public class UsingLambdaWithDelegate : IClassRoom
    {
        delegate void WriteTextInConsole(string text);

        public void RunTest()
        {
            WriteTextInConsole writeTextInConsole = (customerName) => Console.WriteLine($"Welcome {customerName}!");
            writeTextInConsole("John");
            writeTextInConsole("Mary");

            writeTextInConsole = (message) => Console.WriteLine(message);
            writeTextInConsole("This is a message for you!");

            writeTextInConsole = (customerName) => Console.WriteLine($"Bye bye {customerName}!");
            writeTextInConsole("John");
            writeTextInConsole("Mary");
        }
    }
}
