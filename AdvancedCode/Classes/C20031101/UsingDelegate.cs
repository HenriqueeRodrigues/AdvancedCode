using AdvancedCode.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCode.Classes.C20031101
{
    public class UsingDelegate : IClassRoom
    {
        delegate void WriteInConsole();

        private void WriteWelcome()
        {
            Console.WriteLine("Welcome to our class!");
        }

        private void WriteMessage()
        {
            Console.WriteLine("Today we'll talk about delegate!");
        }

        private void WriteBye()
        {
            Console.WriteLine("Bye bye!");
        }

        public void RunTest()
        {
            WriteInConsole writeInConsole = WriteWelcome;            
            writeInConsole();

            writeInConsole = WriteMessage;
            writeInConsole();

            writeInConsole = WriteBye;
            writeInConsole();
        }
    }
}
