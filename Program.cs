using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int redniBroj = 1;
            int[] niz = new int[5];

            Console.WriteLine("Vježba 2- klase i objekti\n");
            Console.WriteLine("Upiši 5 brojeva");

            for (int brojac = 0; brojac < niz.Length; brojac++)
            {
                Console.WriteLine(redniBroj + ". broj: ");
                niz[brojac] = Convert.ToInt32(Console.ReadLine());
                redniBroj++;
            }
            KlasaC objekt = new KlasaC();

            Console.WriteLine("Zbroj članova niza je: " + objekt.Zbroj(niz));
            Console.WriteLine("Prosjek članova niza je: " + objekt.Prosjek(niz));

            Console.ReadKey();
        }
    }

    class KlasaC
    {

        int zbroj;

        public int Zbroj(int[] niz)
        {
            int zbroj = 0;
            for (int brojac = 0; brojac < niz.Length; brojac++)
            {
                zbroj += niz[brojac];
            }
            return zbroj;
        }


        public double Prosjek(int[] niz)
        {
            double zbroj = Zbroj(niz);
            double prosjek = zbroj / niz.Length;
            return prosjek;
        }
    }
}
