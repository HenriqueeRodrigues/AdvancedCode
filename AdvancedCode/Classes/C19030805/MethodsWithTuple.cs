using AdvancedCode.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCode.Classes.C19030805
{
    public class MethodsWithTuple : IClassRoom
    {
        public void RunTest()
        {
            var customerTotalValue = GetCustomerTotalValue();
            Console.WriteLine(customerTotalValue.Item1 + " Purchased: " + customerTotalValue.Item2.ToString("c2"));

            var customerTotalValueWithName = GetCustomerTotalValueWithName();            
            Console.WriteLine(customerTotalValueWithName.CustomerName + " Purchased: " + customerTotalValueWithName.TotalValue.ToString("c2"));

            var customerTotalValues = GetCustomerTotalValues();

            foreach(var customer in customerTotalValues)
            {
                Console.WriteLine(customer.CustomerName + " Purchased: " + customer.TotalValue.ToString("c2"));
            }
        }

        public (string, decimal) GetCustomerTotalValue()
        {
            return ("John", 1500m);
        }

        public (string CustomerName, decimal TotalValue) GetCustomerTotalValueWithName()
        {
            return (CustomerName: "John", TotalValue: 1500m);
        }

        public IEnumerable<(string CustomerName, decimal TotalValue)> GetCustomerTotalValues()
        {
            var customers = new List<(string CustomerName, decimal TotalValue)>();
            customers.Add(("John", 1500m));
            customers.Add(("Mary", 800m));
            customers.Add(("Peter", 200m));
            customers.Add(("Fred", 500m));
            customers.Add(("John 2", 1800m));

            return customers;
        }
    }
}
