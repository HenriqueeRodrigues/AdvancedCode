using AdvancedCode.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCode.Classes.C20031102
{
    public class UsingDelegate : IClassRoom
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

            writeTextInConsole = WriteMessage;
            writeTextInConsole($"You purchased {150} in this day.");
            writeTextInConsole($"You purchased {180} in this day.");
            writeTextInConsole($"You purchased {210} in this day.");

            writeTextInConsole = WriteBye;
            writeTextInConsole("John");
        }
    }
}
