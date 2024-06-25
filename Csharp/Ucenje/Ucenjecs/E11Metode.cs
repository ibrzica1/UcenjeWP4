using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenjecs
{
    internal class E11Metode
    {public static void Izvedi()
        {
            for(int i = 0; i < 55; i++)
            {
                Tip1();
                
            }
            Tip2("Edunova");
            Tip2("Ivan", "Marko");
            int broj = Tip3();
            Console.WriteLine(broj);
            Console.WriteLine(Tip4(2,8));



        }
        private static void Tip1()
        {
            Console.WriteLine("Hello");
        }
        static void Tip2(string ime)
        {
            Console.WriteLine("Hello {0}", ime);
        }
        static void Tip2(string ime, string prezime)
        {
            Console.WriteLine("");
        }
        static int Tip3()
        {
            return new Random().Next();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="odBroja"></param>
        /// <param name="doBroja"></param>
        /// <returns></returns>
        protected static int Tip4(int odBroja, int doBroja)
        {
            int suma = 0;
            for ( int i = odBroja; i <= doBroja; i++)
            {
                suma += i;
            }
            return suma;
        }

    }
         
}
