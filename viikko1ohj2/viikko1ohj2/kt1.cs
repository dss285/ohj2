using System;

namespace viikko1ohj2
{
    class Program
    {
        public struct Tietue
        {
            public int polttoainemaara, matka;
        }
        static void Main(string[] args)
        {
            Tietue rk;
            rk.polttoainemaara = int.Parse(Console.ReadLine());
            rk.matka = int.Parse(Console.ReadLine());
            rk.matka /= 100;
            Console.WriteLine("Polttoainekulutus: {0}",rk.polttoainemaara/rk.matka);
        }
    }
}
