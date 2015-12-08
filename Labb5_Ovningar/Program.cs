using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb5_Ovningar
{
    public class Program
    {
        public void Main(string[] args)
        {
            Uppgift1();

            "hej"
        }

        private static void Uppgift1()
        {
            object myObject = new object();
            string myString = "tjosan!";
            int intTal = 10;
            double doubleTal = 4.5;
            char myChar = 'B';
            bool isFalse = true;
            bool isTrue = false;

            object myObject2 = myString;
            Console.WriteLine(myObject2);
            myObject2 = doubleTal;
            Console.WriteLine(myObject2);

            string myString2 = intTal.ToString();
            Console.WriteLine(myString2);
            double doubleTal2 = intTal;
            Console.WriteLine(doubleTal2);
            string myString3 = doubleTal.ToString();
            Console.WriteLine(myString3);
            myString = "15";
            double doubleTal3 = Double.Parse(myString);
            Console.WriteLine(myString);
            string myString4 = myChar.ToString();
            Console.WriteLine(myString4);

            Console.ReadLine();
        }
    }
}
