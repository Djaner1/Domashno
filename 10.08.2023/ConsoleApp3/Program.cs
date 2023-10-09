using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = "111011000";
            int number2=Convert.ToInt32(number,10);
            string number3 = Convert.ToString(number2, 16);
            Console.WriteLine(number3);

        }
    }
}
