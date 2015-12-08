using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift30
{
    class Program
    {
        static void Main(string[] args)
        {
            Number thisRandom = new Number();
            Console.WriteLine("Type a number: ");
            thisRandom.SetQuartNumber(int.Parse(Console.ReadLine()));
            Console.WriteLine(thisRandom.printNumber());
        }
    }
}