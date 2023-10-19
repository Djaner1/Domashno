using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._19._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter V-");
            float v = float.Parse(Console.ReadLine());
            Console.Write("Enter T-");
            float t = float.Parse(Console.ReadLine());
            Console.Write("Enter a-");
            float a=float.Parse(Console.ReadLine());
            double s=(v*t)+(Math.Pow(a*t,2)/2);
            Console.WriteLine("S="+s);


        }
    }
}
