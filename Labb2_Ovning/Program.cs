using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Ovning
{
    class Program
    {
        static void Main(string[] args)
        {
            del1();
            del2();
            del3();
            del4();
        }

        private static void del4()
        {
            double dowJones = 4.6;
            double nasdaq = 4.1;
            double stockholm = -2.4;
            double milano = -6.7;
            double paris = -5.5;

            Console.WriteLine($"Dow Jones sjönk med {dowJones} procent och Nasdaq med {nasdaq} procent. Stockholm {stockholm} procent, Milano {milano} procent, Paris {paris} procent.");
        }

        private static void del3()
        {
            string jonas = "bor i Helsinborg på Stattena vid Hemköp";
            Console.WriteLine($"Han heter Jonas och {jonas}");
        }

        private static void del2()
        {
            const double pi = 3.141592654;
            Console.WriteLine($"Talet π är cirka {pi:N9} men kan avrundas till {pi:N6} och kan lite grovt skrivas som {pi:N0}");
        }

        private static void del1()
        {
            int year = 34;
            Console.WriteLine("Hej jag är {0} år", year);

            year = 55;
            Console.WriteLine("Hej jag är {0} år", year);
        }
    }
}
