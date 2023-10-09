using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = "FB4";
            int number2=Convert.ToInt32(number,2);
            Console.WriteLine(number2);

        }
    }
}
