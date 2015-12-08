using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    class Car
    {
        private string brand;
        private int gears;
        private string color;
        private string type;


        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public int Gears
        {
            get { return gears; }
            set { gears = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Type
        {
            get { return type; }
            set
            {
                var validCars = value == "kupe" || value == "kombi";
                if (validCars)
                    type = value;
                else
                    throw new Exception("Not right type of car");
            }
        }
        public Car(string type)
        {
            Type = type;
        }

        public override string ToString()
        {
            return $"Type: {Type}";
        }
    }
}
