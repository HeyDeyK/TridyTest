using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridyTest
{
    class Osoba
    {
        public int pocetOsob = 0;
        public Osoba()
        {
            pocetOsob++;
        }
        public int vek;
        public string jmeno;
        private string nazev;
        public virtual void VypisJmeno() { Console.WriteLine("Jsem osoba jménem "+jmeno); }
        public string DejNazev
        {
            get { return nazev; }
            set { nazev = value; }
        }
    }
}
