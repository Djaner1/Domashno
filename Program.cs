using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double max = double.MinValue;
double min=double.MaxValue;
            var height = new Dictionary<string, double>();            
            height["Dimitar"] = 1.90;
            height["Viktor"] = 1.89;
            height["Ivan"] = 1.50;
            height["Aleks"] = 1.86;
            height["Djemal"] = 1.68;
            height["Anil"] = 1.58;
            height["Vladislav"] = 1.79;
            height["Petur"] = 1.93;
            height["Emil"] = 1.65;
            height["Djaner"] = 1.78;
            height["Dean"] = 2.00;

            Console.WriteLine("Vuv basketbolniq otbor igraqt:");
            foreach (var i in height)
            {
                if (i.Value >=1.85)
                {
                    Console.WriteLine(i.Key);
                    if(i.Value >max) max = i.Value;
                }
            }
            height["Yoan"] = 1.80;
            height["Stoyan"] = 1.50;
            height["Boris"] = 1.69;
            height["Hristo"] = 1.30;
            height["Preslav"] = 1.80;


            Console.WriteLine("Vuv futbolniq otbor igraqt:");
            foreach (var i in height)
            {
                if (i.Value < 1.85)
                {
                    Console.WriteLine(i.Key);
                    if(i.Value<min) min = i.Value;
                }
            }

            Console.WriteLine("Proverqvane za 'Djaner'");
            if (height.ContainsKey("Djaner"))
            {
                Console.WriteLine("Da ima takuv uchenik");
            }else
                Console.WriteLine("Nqma takuv uchenik");

            Console.WriteLine("Nai niskiqt ot futbolniq otbor-"+min);
            Console.WriteLine("Nai visokiqt ot basketbolniq otbor-"+max);



        }
    }
}
