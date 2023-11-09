using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._9._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine());
            int m=int.Parse(Console.ReadLine());
            int[,] masiv = new int[n, m];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    masiv[i,j]=int.Parse(Console.ReadLine());

                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if(masiv[i,j]/2==0)
                    {
                        Console.WriteLine(masiv[i,j]);
                    }

                }
            }



        }
    }
}
