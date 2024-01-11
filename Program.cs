using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visochina_na_uchenici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double max = double.MinValue;
            var height=new Dictionary<string,double>();
            height["Dimitar"] = 1.80;
            height["Viktor"] = 1.77;
            height["Ivan"] = 1.50;
            height["Aleks"]=1.84;
            foreach(var i in height)
            {
                Console.WriteLine("{0}--{1}",i.Key,i.Value);                
            }
            height["Djaner"] = 1.78;
            foreach (var i in height)
            {
                if(i.Value>max) max=i.Value;

            }
            var keyOfMaxValue =
    height.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            Console.WriteLine("Nai visokiq uchenik-"+keyOfMaxValue);
            var total = height.Sum(v => v.Value);
            double sr = total / height.Count;
            Console.WriteLine(total);
            Console.WriteLine("sredna visochina-"+sr);
            Console.WriteLine("Broi na uchenici="+height.Count);



        }
    }
}
