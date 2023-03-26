using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023.elsotizparososszege
{
    class Program
    {
        static void Main(string[] args)
        {
            int szamlalo = 0;
            int osszeg = 0;

            for (int i = 0; i < 101; i++)
            {
                if (i % 2 == 0)
                {

                    szamlalo = szamlalo + 1;
                    osszeg = osszeg + i;

                    if (szamlalo > 10)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(osszeg);

            Console.ReadKey();
        }
    }
}
