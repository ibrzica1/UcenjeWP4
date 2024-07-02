using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenjecs.E15RadSaStringovima
{
    internal class Program
    {
        public Program() 
        {

            var s = "Edunova";

            Console.WriteLine(s.GetHashCode());

            s = "Osijek";
            Console.WriteLine(s.GetHashCode());

            var sb = new StringBuilder();

            sb.AppendLine("Edunova");

            Console.WriteLine(sb.GetHashCode());

            sb.Clear();

            sb.AppendLine("Osijek");

            Console.WriteLine(sb.GetHashCode());

            sb = new StringBuilder();
            sb.Append('a');
            sb.Append(" b");
            sb.Append('c');

            Console.WriteLine(sb);

            

        }
    }
}
