using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABB1_Hantera_varor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Skapa vara");
            Console.WriteLine("2 - Inventera vara");
            Console.WriteLine("3 - Lista vara");
            Console.WriteLine("4 - Avsluta");
            int UserAlternative;
            int.TryParse(Console.ReadLine(), out UserAlternative);
        }
    }
}
