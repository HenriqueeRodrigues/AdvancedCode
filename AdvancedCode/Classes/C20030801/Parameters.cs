using AdvancedCode.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCode.Classes.C20030801
{
    public class Parameters : IClassRoom
    {
        public void RunTest()
        {
            WriteDetails("John", "Last Av.", "New York", 30, 1000m);
            WriteDetails("Mary", "Last Av.", "New York", 30);
            WriteDetails("Mark", "Last Av.", "New York");
            WriteDetails("Luke", "Last Av.", "New York", totalPurchased: 2000m);
        }

        public void WriteDetails(string customerName, string address, string city, int age = 0, decimal totalPurchased = 0)
        {
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Customer Address: " + address);
            Console.WriteLine("Customer City: " + city);

            if (age > 0)
            {
                Console.WriteLine("Customer Age: " + age);
            }

            if (totalPurchased > 0)
            {
                Console.WriteLine("Customer Total Purchased: " + totalPurchased);
            }
        }
    }
}
