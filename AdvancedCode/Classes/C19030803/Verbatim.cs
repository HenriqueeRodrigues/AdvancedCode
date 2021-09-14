using AdvancedCode.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCode.Classes.C19030803
{
    public class Verbatim : IClassRoom
    {
        public void RunTest()
        {
            string sql = "select * from Customers c " + 
                " inner join Orders o on o.CustomerId = c.CustomerId " +
                " where c.CustomerId = 15 " +
                " order by c.CustomerName ";

            string newSQL = @"select * from Customers c
                                inner join Orders o on o.CustomerId = c.CustomerId
                                where c.CustomerId = 15
                                order by c.CustomerName";

            Console.WriteLine(sql);
            Console.WriteLine(newSQL);

            //Another example
            string file = "c:\\documents\\files\\myfile.txt";
            string newFile = @"c:\documents\files\myfile.txt";

            Console.WriteLine(file);
            Console.WriteLine(newFile);

            //Another example
            string[] @for = new[] { "John", "Mark" };                
            int @class = 0;

            foreach (string @string in @for)
            {
                Console.WriteLine(@string);
            }

            Console.WriteLine(@class);
        }
    }
}
