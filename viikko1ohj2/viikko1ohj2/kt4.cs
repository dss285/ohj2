using System;

namespace viikko1ohj2
{
    class Program
    {

        public class Omistaja
        {
            public string etunimi, sukunimi, hetu;
            public void Kysytiedot()
            {
                Console.WriteLine("Etunimi");
                this.etunimi = Console.ReadLine();

                Console.WriteLine("Sukunimi");
                this.sukunimi = Console.ReadLine();

                Console.WriteLine("HETU");
                this.hetu = Console.ReadLine();
            }
        }
        public class Auto
        {
            public string merkki, malli, tyyppi, omistaja, rekisterinro;
            public int vuosimalli;
            public Omistaja omis;
            public void Kysytiedot()
            {
                Console.WriteLine("Merkki:");
                this.merkki = Console.ReadLine();

                Console.WriteLine("Malli:");
                this.malli = Console.ReadLine();

                Console.WriteLine("Tyyppi");
                this.tyyppi = Console.ReadLine();

                Console.WriteLine("Vuosimalli");
                this.vuosimalli = int.Parse(Console.ReadLine());

                Console.WriteLine("Rekisterinumero");
                this.rekisterinro = Console.ReadLine();

                Console.WriteLine("Omistajan Tiedot");
                this.omis = new Omistaja();
                this.omis.Kysytiedot();
            }
        }
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            auto.Kysytiedot();
        }
        
    }
}
