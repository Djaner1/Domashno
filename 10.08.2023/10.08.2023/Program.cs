using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._08._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime birthday = DateTime.Parse("2007/08/29");
            DateTime now = DateTime.Parse(DateTime.Now.ToString());
            int days = (now - birthday).Days;
            Console.WriteLine("ot rojdenniq vi den sa minali {0} dena",days);

            


        }
    }
}
