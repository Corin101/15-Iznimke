using System;
using System.IO;

namespace Vsite.CSharp
{
    // Primjer filtera iznimki
    class Program
    {
        static void Main(string[] args)
        {
            // u petlji bacamo razli�ite tipove iznimki i pratimo tko �e ih uhvatiti
            Exception[] iznimke = new Exception[] { new FileNotFoundException(), 
                new ArgumentOutOfRangeException(), new ArgumentException() };

            for (int i = 0; i < iznimke.Length; ++i)
            {
                try
                {
                    throw iznimke[i];
                }
                // TODO: Slo�iti filtere iznimki tipa Exception, ArgumentOutOfRangeException i ArgumentException te provjeriti koja �e iznimka biti uhva�ena u kojem bloku.
                catch (Exception e)
                {
                    Console.WriteLine("Exception");
                    Console.WriteLine(e);
                    Console.WriteLine();
                }
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
