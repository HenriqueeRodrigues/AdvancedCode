using AdvancedCode.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCode.Classes.C19030802
{
    public class StringInterpolation : IClassRoom
    {
        public void RunTest()
        {
            string customerName = "John Mark Bar";

            string description = "Customer Name: " + customerName + ". He is a customer since " + DateTime.Now.ToString("dd/MM/yyyy") + ".";

            string anotherWayDescription = $"Customer Name: {customerName}. He is a customer since {DateTime.Now.ToString("dd/MM/yyyy")}.";

            Console.WriteLine(description);
            Console.WriteLine(anotherWayDescription);

            // Another example
            string alignmentText = $"Customer Name (left): {customerName, -20}.";
            Console.WriteLine(alignmentText);

            alignmentText = $"Customer Name (right): {customerName, 20}.";
            Console.WriteLine(alignmentText);

            //Another example 29800.899
            decimal orderValue = 29800.899m;
            //string customerOrder = $" This customer purchased: {orderValue,20}";
            string customerOrder = $"This customer purchased: {orderValue,20:F2}";
            Console.WriteLine(customerOrder);

            orderValue = 350.50m;
            customerOrder = $"This customer purchased: {orderValue,20:F2}";
            Console.WriteLine(customerOrder);
        }
    }
}
