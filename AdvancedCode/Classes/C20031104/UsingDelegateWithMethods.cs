using AdvancedCode.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCode.Classes.C20031104
{
    public class UsingDelegateWithMethods : IClassRoom
    {
        delegate void WriteTextInConsole(string text);

        private void WriteWelcome(string customerName)
        {
            Console.WriteLine($"Welcome {customerName}!");
        }

        private void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }

        private void WriteBye(string customerName)
        {
            Console.WriteLine($"Bye bye {customerName}!");
        }

        public void RunTest()
        {
            WriteTextInConsole writeTextInConsole = WriteWelcome;
            writeTextInConsole("John");
            writeTextInConsole("Mary");
            writeTextInConsole("Peter");

            writeTextInConsole = WriteMessage;
            writeTextInConsole("This is a message for you!");

            writeTextInConsole = WriteBye;
            writeTextInConsole("John");
            writeTextInConsole("Mary");
            writeTextInConsole("Peter");
        }
    }
}
