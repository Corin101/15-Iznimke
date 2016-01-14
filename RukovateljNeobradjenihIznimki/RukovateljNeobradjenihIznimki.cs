using System;
using System.Collections.Generic;
using System.Text;

namespace Vsite.CSharp
{
    // Primjer definiranja obrade UnhandledException doga�aja
    // Ovo omogu�ava da zapi�emo sve neuhva�ene iznimke (npr. 
    // u log datoteku), no program �e jo� uvijek imati
    // unhandled exception!
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Odkomentirati donju naredbu te doga�aju UnhandledException prdru�iti rukovatelja koji �e ispisati podatke o neuhva�enoj iznimci te pozvati Console.ReadKey() da privremeno zaustavi izvo�enje. Pokrenuti program i provjeriti pona�anje.
            //AppDomain.CurrentDomain.UnhandledException;

            try
            {
                throw new Exception("1");
            }
            catch (Exception e)
            {
                Console.WriteLine("Uhva�ena iznimka: " + e.Message);
            }
            throw new Exception("2");
        }

    }
}
