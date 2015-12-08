using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift14
{
    class EvenNumbers
    {
        public void PrintEvenNumbers(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
