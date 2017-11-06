using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridyTest
{
    class Zak : Osoba
    {
        public int pocetZaku = 0;
        public string trida;
        public Zak()
        {
            pocetZaku++;
            pocetOsob++;
        }
        public override void VypisJmeno()
        {
            Console.WriteLine("Jsem žák jménem " + jmeno);
        }
    }
}
