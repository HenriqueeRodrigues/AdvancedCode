using AdvancedCode.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCode
{
    class Program
    {
        static void Main(string[] args)
        {
            IClassRoom classRoom = new Classes.C20030803.YieldClassTests();
            classRoom.RunTest();

            Console.ReadLine();
        }
    }
}
