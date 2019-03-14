using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OxidProject_Acids
{
    public class OxidProject
    {
        public static string ElementA = "§";
        public static void Main(string[] args)
        {
            Console.Title = "~ OxidProject ~";
            Console.WriteLine("Zadajte kyselinotvorny prvok");
            ElementA = Console.ReadLine();
            Console.WriteLine();
            for (int i = 1; i <= 8; i++)
            {
                Calc(i);
            }
            Console.ReadKey();
            Console.Clear();
        }

        private static void Calc(int i)
        {
            if (i >= 1 && i <= 8)
            {
                int i1, i2;
                i1 = i % 2 == 0 ? 2 : 1;
                i2 = (i1 + i) / 2;
                Console.WriteLine("{0} : H{1}{2}O{3}", i, i1 != 1? i1+"" : "", ElementA, i2 != 1? i2 + "" : "");
            }
        }
    }
}
