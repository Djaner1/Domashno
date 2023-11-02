using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._2._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] suma = new int[2, 2];
            int obshto1=0;
            int obshto2=0;
            for(int i = 0; i <2; i++)
            {
                for(int o=0; o<2; o++)
                {
                    suma[i, o] = int.Parse(Console.ReadLine());
                     obshto1 = suma[0, 0] + suma[0, 1];
                     obshto2 = suma[1,0] + suma[1, 1];
                }
            }
            Console.WriteLine("Sumata za 1 red e "+obshto1);
            Console.WriteLine("Sumata za 2 red e "+obshto2);

        }
    }
}
