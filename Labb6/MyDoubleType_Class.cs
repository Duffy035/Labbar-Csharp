using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Labb6
{
    class MyDoubleType_Class
    {
        private double doubleValue;

        public double DoubleValue
        {
            get { return doubleValue; }
            set { doubleValue = value; }
        }

        public MyDoubleType_Class(double doubleValue)
        {
            this.doubleValue = doubleValue;
        }



        //addition
        public static MyDoubleType_Class operator +(MyDoubleType_Class value, double value2)
        {
            return new MyDoubleType_Class(value.DoubleValue + value2);
        }

        public static MyDoubleType_Class operator +(MyDoubleType_Class value, MyDoubleType_Class value2)
        {
            return new MyDoubleType_Class(value.DoubleValue + value2.DoubleValue);
        }



        //subtraction
        public static MyDoubleType_Class operator -(MyDoubleType_Class value, double value2)
        {
            return new MyDoubleType_Class(value.DoubleValue - value2);
        }

        public static MyDoubleType_Class operator -(MyDoubleType_Class value, MyDoubleType_Class value2)
        {
            return new MyDoubleType_Class(value.DoubleValue - value2.DoubleValue);
        }



        //division
        public static MyDoubleType_Class operator /(MyDoubleType_Class value, double value2)
        {
            return new MyDoubleType_Class(value.DoubleValue / value2);
        }

        public static MyDoubleType_Class operator /(MyDoubleType_Class value, MyDoubleType_Class value2)
        {
            return new MyDoubleType_Class(value.DoubleValue / value2.DoubleValue);
        }



        //multiplikation
        public static MyDoubleType_Class operator *(MyDoubleType_Class value, double value2)
        {
            return new MyDoubleType_Class(value.DoubleValue * value2);
        }

        public static MyDoubleType_Class operator *(MyDoubleType_Class value, MyDoubleType_Class value2)
        {
            return new MyDoubleType_Class(value.DoubleValue * value2.DoubleValue);
        }



        //== och !=
        public static bool operator ==(MyDoubleType_Class value, MyDoubleType_Class value2)
        {
            return value.doubleValue == value2.doubleValue;
        }

        public static bool operator !=(MyDoubleType_Class value, MyDoubleType_Class value2)
        {
            return value.doubleValue != value2.doubleValue;
        }



        //< och >
        public static bool operator >(MyDoubleType_Class value, MyDoubleType_Class value2)
        {
            return value.doubleValue > value2.doubleValue;
        }

        public static bool operator <(MyDoubleType_Class value, MyDoubleType_Class value2)
        {
            return value.doubleValue < value2.doubleValue;
        }


        //<= och >=
        public static bool operator >=(MyDoubleType_Class value, MyDoubleType_Class value2)
        {
            return value.doubleValue >= value2.doubleValue;
        }

        public static bool operator <=(MyDoubleType_Class value, MyDoubleType_Class value2)
        {
            return value.doubleValue <= value2.doubleValue;
        }
        public override string ToString() => $"Double value: {doubleValue}";
    }
}
