using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();
            osoba.vek = 50;
            osoba.jmeno = "Jirka";
            //Console.WriteLine(osoba.DejNazev);
            Zak zak = new Zak();
            zak.jmeno = "Alfred";
            osoba.VypisJmeno();
            zak.VypisJmeno();
            Console.Read();

        }
    }
}
