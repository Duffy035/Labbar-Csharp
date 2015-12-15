using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Labb6
{
    struct MyDoubleType_Struct
    {
        private double doubleValue;

        public double DoubleValue
        {
            get { return doubleValue; }
            set { doubleValue = value; }
        }

        public MyDoubleType_Struct(double doubleValue)
        {
            this.doubleValue = doubleValue;
        }



        //addition
        public static MyDoubleType_Struct operator +(MyDoubleType_Struct value, double value2)
        {
            value.doubleValue += value2;
            return value;
        }

        public static MyDoubleType_Struct operator +(MyDoubleType_Struct value, MyDoubleType_Struct value2)
        {
            value.doubleValue += value2.doubleValue;
            return value;
        }


        //subtraction
        public static MyDoubleType_Struct operator -(MyDoubleType_Struct value, double value2)
        {
            value.doubleValue -= value2;
            return value;
        }

        public static MyDoubleType_Struct operator -(MyDoubleType_Struct value, MyDoubleType_Struct value2)
        {
            value.doubleValue -= value2.doubleValue;
            return value;
        }



        //division
        public static MyDoubleType_Struct operator /(MyDoubleType_Struct value, double value2)
        {
            value.doubleValue /= value2;
            return value;
        }

        public static MyDoubleType_Struct operator /(MyDoubleType_Struct value, MyDoubleType_Struct value2)
        {
            value.doubleValue /= value2.doubleValue;
            return value;
        }



        //multiplikation
        public static MyDoubleType_Struct operator *(MyDoubleType_Struct value, double value2)
        {
            value.doubleValue *= value2;
            return value;
        }

        public static MyDoubleType_Struct operator *(MyDoubleType_Struct value, MyDoubleType_Struct value2)
        {
            value.doubleValue *= value2.doubleValue;
            return value;
        }



        //== och !=
        public static bool operator ==(MyDoubleType_Struct value, MyDoubleType_Struct value2)
        {
            return value.doubleValue == value2.doubleValue;
        }

        public static bool operator !=(MyDoubleType_Struct value, MyDoubleType_Struct value2)
        {
            return value.doubleValue != value2.doubleValue;
        }



        //< och >
        public static bool operator >(MyDoubleType_Struct value, MyDoubleType_Struct value2)
        {
            return value.doubleValue > value2.doubleValue;
        }

        public static bool operator <(MyDoubleType_Struct value, MyDoubleType_Struct value2)
        {
            return value.doubleValue < value2.doubleValue;
        }


        //<= och >=
        public static bool operator >=(MyDoubleType_Struct value, MyDoubleType_Struct value2)
        {
            return value.doubleValue >= value2.doubleValue;
        }

        public static bool operator <=(MyDoubleType_Struct value, MyDoubleType_Struct value2)
        {
            return value.doubleValue <=value2.doubleValue;
        }
        public override string ToString() => $"Double value: {doubleValue}";
    }
}
