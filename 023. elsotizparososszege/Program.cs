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

/*kiszámítja az első tíz páros szám összegét. Az alábbiakban röviden összefoglalom, hogy a program mit csinál:

A program elindul, és a "using" utasításokkal importálja a szükséges könyvtárakat.

Definiáljuk a "Program" osztályt, amely tartalmazza a "Main" metódust, ami a program belépési pontja.

A "Main" metóduson belül két változót definiálunk: "szamlalo" és "osszeg". "szamlalo" az eddig feldolgozott páros számokat számolja, míg "osszeg" az eddig feldolgozott páros számok összegét tárolja.

A program egy ciklust indít, amely 0-tól 100-ig megy végig. Minden egyes ciklusban ellenőrizzük, hogy az aktuális szám páros-e. Ha igen, akkor növeljük a "szamlalo" változót eggyel, hozzáadjuk az aktuális számot az "osszeg" változóhoz, majd ellenőrizzük, hogy az első tíz páros számot már feldolgoztuk-e. Ha igen, akkor kilépünk a ciklusból a "break" utasítással.

Végül a program kiírja az "osszeg" változó értékét a konzolra, majd várakozik, amíg a felhasználó bármilyen billentyűt meg nem nyom a "Console.ReadKey()" metódus segítségével.

Összességében ez a program egy egyszerű példa arra, hogy hogyan lehet ciklust használni C# nyelven, és hogyan lehet összeadni számokat egy változóban a ciklus futása közben.*/
