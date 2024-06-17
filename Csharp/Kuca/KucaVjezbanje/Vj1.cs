using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KucaVjezbanje
{
    internal class Vj1
    {
        public static void Izvedi()
        {
          /*  Write a program that inputs n integers and checks 
              whether among them there is a number equal to 
              the sum of all the rest. If there is such an element, 
              print "Yes" + its value, otherwise – "No" + the difference 
              between the largest element and the sum of the rest  */


            Console.WriteLine("Koliko brojeva želiš unijeti: ");
            int n = int.Parse(Console.ReadLine());
            int max = -10000000;
            int ostatak = 0;
            Console.WriteLine("Unesi brojeve: ");
            for (int i = 0; i < n; i++)
            {
                int broj = int.Parse(Console.ReadLine());
                ostatak += broj;
                if (broj > max)
                {
                    max = broj;
                }
            }
            ostatak = ostatak - max;

            if (max == ostatak)
            {
                Console.WriteLine("Da, zbroj je " + max);
            }
            else
            {
                Console.WriteLine("Ne, ostatak je " + (max - ostatak));
            }
            
        }
    }
}
