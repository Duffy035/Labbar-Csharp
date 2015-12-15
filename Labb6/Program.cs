using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uppgift1();
            //Uppgift3();
            //Uppgift4_alt();
            Uppgift4();

        }
        private static void Uppgift4()
        {
            //addition
            MyDoubleType_Struct mdt1 = new MyDoubleType_Struct(5);
            MyDoubleType_Struct mdt2 = mdt1 + 5;
            MyDoubleType_Struct mdt3 = mdt1 + mdt2;

            //subtraction
            MyDoubleType_Struct mdt4 = new MyDoubleType_Struct(5);
            MyDoubleType_Struct mdt5 = mdt4 - 5;
            MyDoubleType_Struct mdt6 = mdt4 - mdt5;

            //division
            MyDoubleType_Struct mdt7 = new MyDoubleType_Struct(5);
            MyDoubleType_Struct mdt8 = mdt7 / 5;
            MyDoubleType_Struct mdt9 = mdt7 / mdt8;

            //Multiplikation
            MyDoubleType_Struct mdt10 = new MyDoubleType_Struct(5);
            MyDoubleType_Struct mdt11 = mdt10 * 5;
            MyDoubleType_Struct mdt12 = mdt10 * mdt11;

            //>, ==
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", mdt1, mdt2, mdt3, mdt1 > mdt2, mdt1 == mdt4);


            Console.WriteLine(mdt1);
            Console.WriteLine(mdt2);
            Console.WriteLine(mdt3);

            Console.WriteLine(mdt4);
            Console.WriteLine(mdt5);
            Console.WriteLine(mdt6);

            Console.WriteLine(mdt7);
            Console.WriteLine(mdt8);
            Console.WriteLine(mdt9);

            Console.WriteLine(mdt10);
            Console.WriteLine(mdt11);
            Console.WriteLine(mdt12);

            Console.ReadLine();
        }
        private static void Uppgift4_alt()
        {
            //addition
            MyDoubleType_Class mdt1 = new MyDoubleType_Class(5);
            MyDoubleType_Class mdt2 = mdt1 + 5;
            MyDoubleType_Class mdt3 = mdt1 + mdt2;

            //subtraction
            MyDoubleType_Class mdt4 = new MyDoubleType_Class(5);
            MyDoubleType_Class mdt5 = mdt4 - 5;
            MyDoubleType_Class mdt6 = mdt4 - mdt5;

            //division
            MyDoubleType_Class mdt7 = new MyDoubleType_Class(5);
            MyDoubleType_Class mdt8 = mdt7 / 5;
            MyDoubleType_Class mdt9 = mdt7 / mdt8;

            //Multiplikation
            MyDoubleType_Class mdt10 = new MyDoubleType_Class(5);
            MyDoubleType_Class mdt11 = mdt10 * 5;
            MyDoubleType_Class mdt12 = mdt10 * mdt11;

            //>, ==
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", mdt1, mdt2, mdt3, mdt1 > mdt2, mdt1 == mdt4);


            Console.WriteLine(mdt1);
            Console.WriteLine(mdt2);
            Console.WriteLine(mdt3);

            Console.WriteLine(mdt4);
            Console.WriteLine(mdt5);
            Console.WriteLine(mdt6);

            Console.WriteLine(mdt7);
            Console.WriteLine(mdt8);
            Console.WriteLine(mdt9);

            Console.WriteLine(mdt10);
            Console.WriteLine(mdt11);
            Console.WriteLine(mdt12);

            Console.ReadLine();
        }
        private static void Uppgift3()
        {
            Point point = new Point(10, 20);
            Point3D point3D = new Point3D(555,666,777);
            Point3D point2 = (Point3D) point;
            Point point3 = (Point) point3D;

            Console.WriteLine(point);
            Console.WriteLine(point3D);
            Console.WriteLine(point2);

            Console.ReadLine();
        }
        private static void Uppgift1()
        {
            Literals literals = new Literals();
            Console.WriteLine(literals);
            Console.ReadLine();
        }

    }
}
