using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi imeto na fitnesa");
            string name = Console.ReadLine();
            List<string> gym=Console.ReadLine().Split(',').ToList();
            Console.WriteLine("Na koi ured iskate da trenirate");
            string machine=Console.ReadLine();
            for(int i=0; i < gym.Count; i++)
            {
                if (machine == gym[i])
                    Console.WriteLine("Ima takuv ured");
                else
                    Console.WriteLine("Nqma takuv ured");
                Console.WriteLine(gym[i]+" "+name);
            }
            gym.Add("Leg press");
            Console.WriteLine("Broq na uredite-"+gym.Count);

        }
    }
}
