using System;

namespace viikko1ohj2
{
    class Program
    {
        public struct Pythagora
        {
            public double a, b, c;
            public void Ratkaisepuuttuva()
            {
                if((a == 0&& b == 0)||(b == 0&& c == 0)||(c == 0&& a == 0))
                {
                    Console.WriteLine("Ei ratkaisua");
                    return;
                }

                if(a == 0)
                {
                    a = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(b, 2));
                    return;
                }
                if(b == 0)
                {
                    b = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2));
                    return;
                }
                if(c == 0)
                {
                    c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                    return;
                }
            }
        }
        static void Main(string[] args)
        {
            Pythagora muuttuja;
            muuttuja.a = 0;
            muuttuja.b = 5;
            muuttuja.c = 8;
            muuttuja.Ratkaisepuuttuva();
        }
        
    }
}
