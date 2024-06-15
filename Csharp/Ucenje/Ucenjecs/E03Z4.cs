using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenjecs
{
    internal class E03Z4
    {
        public static void Izvedi()
        {
            string grad;
            Console.WriteLine("Unesi ime grada: ");
            grad = Console.ReadLine();  
            if (grad == "osijek")
            {
                Console.WriteLine("Slavonija");
            }
            else if (grad == "zadar")
            {
                Console.WriteLine("Dalmacija");
            }
            else if(grad == "čakovec")
            {
                Console.WriteLine("Međimurje");
                    }
            else if (grad == "pula")
            {
                Console.WriteLine("Istra");
            }
            else
            {
                Console.WriteLine("Ne znam regiju");
            }
        }
    }
}
