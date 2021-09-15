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
            IClassRoom classRoom = new Classes.C19030806.MethodWithParams();
            classRoom.RunTest();

            Console.ReadLine();
        }
    }
}
