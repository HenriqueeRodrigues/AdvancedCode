using AdvancedCode.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCode.Classes.C20030803
{
    public class YieldClassTests : IClassRoom
    {
        public void RunTest()
        {   
            foreach (var bank in AllBanks())
            {
                Console.WriteLine(bank.ToString());
            }

            foreach(var digit in GetSingleDigits())
            {
                Console.WriteLine(digit);
            }
        }

        public IEnumerable<Banks> AllBanks()
        {
            yield return Banks.Bradesco;
            yield return Banks.Itau;
            yield return Banks.BancoDoBrasil;
            yield return Banks.Nu;
        }

        public IEnumerable<int> GetSingleDigits()
        {
            Console.WriteLine("Before for...");

            for (int count = 0; count <= 9; count++)
            {
                Console.WriteLine("In the for...");

                yield return count;
            }

            Console.WriteLine("After for...");
        }
    }

    public enum Banks
    {
        Bradesco = 1,
        Itau = 2,
        BancoDoBrasil = 3,
        Nu = 4
    }
}
