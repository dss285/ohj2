using System;

namespace viikko1ohj2
{
    class Program
    {
        public struct Tietue
        {
            public int paino;
            public double pituus;
            public string etunimi, sukunimi;
        }
        public static void LaskePainoindeksi(Tietue[] taulukko)
        {
            foreach(Tietue x in taulukko)
            {
                Console.WriteLine("Etunimi: {0} | Sukunimi: {1} | Painoindeksi: {2}",x.etunimi,x.sukunimi,x.paino/Math.Pow((double)x.pituus,2));
            }
        }
        public static Tietue[] KysyTiedot()
        {
            Tietue[] taulukko = new Tietue[10];
            for (int i = 0; i < taulukko.Length; i++)
            {
                Tietue muuttuja;

                Console.WriteLine("Etunimi:");
                muuttuja.etunimi = Console.ReadLine();


                Console.WriteLine("Sukunimi:");
                muuttuja.sukunimi = Console.ReadLine();


                Console.WriteLine("Paino (kg):");
                muuttuja.paino = int.Parse(Console.ReadLine());


                Console.WriteLine("Pituus (m):");
                muuttuja.pituus = Double.Parse(Console.ReadLine());

                taulukko[i] = muuttuja;
            }
            return taulukko;
        }
        static void Main(string[] args)
        {
            Tietue[] taulukko = KysyTiedot();
            LaskePainoindeksi(taulukko);
        }
        
    }
}
