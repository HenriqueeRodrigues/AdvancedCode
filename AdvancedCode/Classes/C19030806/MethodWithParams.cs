using AdvancedCode.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCode.Classes.C19030806
{
    public class MethodWithParams : IClassRoom
    {
        public void RunTest()
        {
            /*DeleteCustomerId(1);
            DeleteCustomerId(2);
            DeleteCustomerId(10);

            DeleteCustomerId(new List<int> { 1, 2, 10 });*/
            
            DeleteCustomerIdWithParams(1);
            DeleteCustomerIdWithParams(1, 2, 3, 10, 15);
            DeleteCustomerIdWithParams("Another descriptions - Delete customer with id: ", 1, 2, 3, 10, 15);

            WriteSomething("Test", 1, "Customer", 3, 4, 5);
        }

        public void DeleteCustomerId(int id)
        {
            Console.WriteLine("Delete customer with id: " + id);
        }

        public void DeleteCustomerId(List<int> ids)
        {
            foreach (var id in ids)
            {
                Console.WriteLine("Delete customer with id: " + id);
            }
        }

        public void DeleteCustomerIdWithParams(params int[] ids)
        {
            foreach(var id in ids)
            {
                Console.WriteLine("Delete customer with id: " + id);
            }
        }

        public void DeleteCustomerIdWithParams(string description, params int[] ids)
        {
            foreach (var id in ids)
            {
                Console.WriteLine(description + id);
            }
        }

        public void WriteSomething(params object[] somethings)
        {
            foreach (var something in somethings)
            {
                Console.WriteLine(something);
            }
        }
    }
}
