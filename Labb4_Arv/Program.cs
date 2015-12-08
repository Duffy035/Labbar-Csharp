using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4_Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uppgift1();
            //Uppgift2();
            //Uppgift3();
            //Uppgift4();


        }

        private static void Uppgift4()
        {
            A a = new A();
            A b = new B();
            B c = new C();

            a.Print();
            b.Print();
            c.Print();
            Console.ReadLine();
        }

        private static void Uppgift3()
        {
            Point3D point3d = new Point3D();
            Console.WriteLine(point3d);
            Console.ReadLine();
        }

        private static void Uppgift2()
        {
            Point3D point3d = new Point3D();
            point3d.X = 5;
            point3d.Y = 10;
            point3d.Z = 20;

            Console.WriteLine(point3d);
            Console.ReadLine();
        }

        private static void Uppgift1()
        {
            object myObject = new object();
            string myString = "hejsan";
            int myNumber = 10;
            double myDouble = 5.5;
            char oneCharacter = 'c';
            bool isFalse = true;

            object newObject = myString;
            Console.WriteLine(newObject);
            newObject = myDouble;
            Console.WriteLine(newObject);

            string newString = myObject.ToString();
            Console.WriteLine(newString);
            myString = myDouble.ToString();
            Console.WriteLine(myString);
            

            myString = "45";  //funkar inte med ett decimalvärde! Får 'System.FormatException' error
            double newDouble = double.Parse(myString);
            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
