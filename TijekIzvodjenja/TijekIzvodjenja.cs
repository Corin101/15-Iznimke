using System;

namespace Vsite.CSharp
{
    // ispis tijeka izvo�enja try-catch-finally bloka
    class TijekIzvodjenja
    {
        public const string Zapo�injeBlokTry = "Blok try - po�etak";
        public const string Zavr�avaBlokTry = "Blok try - kraj";
        public const string BlokCatch = "Blok catch";
        public const string BlokFinally = "Blok finally";

        public static void IspisTryCatchFinally(int djeljitelj)
        {
            // TODO: Donje naredbu umetnuti u try-blok te dodati catch blok za hvatanje iznimke u slu�aju dijeljenja s 0 i finally blok. Dodati kontrolne ispise gornjih poruka u svaki od tih blokova te provjeriti �to �e se ispisati.

            Console.WriteLine("Dijelim s {0}", djeljitelj);
            Console.WriteLine(3 / djeljitelj);
            Console.WriteLine("Podijelio sam s {0}", djeljitelj);

        }
        static void Main(string[] args)
        {
            int[] djeljitelji = new int[] { 1, 2, 0 };

            for (int i = 0; i < djeljitelji.Length; ++i)
            {
                IspisTryCatchFinally(djeljitelji[i]);

                Console.WriteLine();
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
