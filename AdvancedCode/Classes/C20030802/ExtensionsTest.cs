using AdvancedCode.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCode.Classes.C20030802
{
    public class ExtensionsTest : IClassRoom
    {
        public void RunTest()
        {
            string customerName = "John Mark Bar";
            customerName.WriteInConsole();

            string test = "This is a test";
            test.WriteInConsole();

            int myNumber = 152343;
            myNumber.WriteInConsole();

            decimal myMoney = 15029.98m;
            Console.WriteLine(myMoney.WriteInReals());
        }
    }

    public static class Extensions
    {
        public static void WriteInConsole(this String text)
        {
            Console.WriteLine(text);
        }

        public static void WriteInConsole(this int number)
        {
            Console.WriteLine("This is the number: " + number);
        }

        public static string WriteInReals(this decimal number)
        {
            return number.ToString("c2");
        }
    }
}
