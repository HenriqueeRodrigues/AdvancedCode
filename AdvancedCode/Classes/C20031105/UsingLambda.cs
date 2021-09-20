using AdvancedCode.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCode.Classes.C20031105
{
    public class UsingLambda : IClassRoom
    {
        delegate void WriteInConsole();

        public void RunTest()
        {
            WriteInConsole writeInConsole = () => Console.WriteLine("This is a sample of using delegate with lambda without args and return");

            WriteSomething(writeInConsole);
        }

        private void WriteSomething(WriteInConsole writeInConsole)
        {
            writeInConsole();
            writeInConsole();
            writeInConsole();
            writeInConsole();
            writeInConsole();
            writeInConsole();
            writeInConsole();
        }
    }
}
