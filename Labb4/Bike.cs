using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    class Bike
    {
        private string brand;
        private int numberOfGears;
        private string type;
        private string color;
        private bool clockBell;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public int NumberOfGears
        {
            get { return numberOfGears; }
            set
            {
                if (value > 0)
                    numberOfGears = value;
                else
                    throw new Exception("You bike must have at least 1 gear?");
            }
        }

        public string Type
        {
            get { return type; }
            set
            {
                if (value != null)
                    type = value;
                else
                    throw new Exception("Your bike must be of a ceratin type...?");
            }
        }

        public string Color
        {
            get { return color; }
            set
            {
                if (value != null)
                    color = value;
                else
                    throw new Exception("Your bike doesn't have a color?");
            }
        }

        public bool ClockBell
        {
            get { return clockBell; }
            set
            {
                if (value == true)
                {
                    clockBell = value;
                    Console.Beep(650, 1000);
                    value = false;
                }
                else
                {
                    throw new Exception("The bike bell is not functioning...");
                }

            }
        }

        public static int bikeCount
        {
            get;
            private set;
        }

        public Bike()
        {
            Brand = "Bridgestone";
            NumberOfGears = 12;
            Type = "Mountainbike";
            Color = "green";
            bikeCount++;
        }

        public Bike(string type) : this()
        {
            Type = type;
        }

        public Bike(string brand, int NumberOfGears) : this(brand)
        {
            Brand = brand;
            NumberOfGears = 2;
            Type = "Child bike";
        }

        public Bike(string brand, int numberOfGears, string type) : this(brand, numberOfGears)
        {
            Brand = brand;
            NumberOfGears = numberOfGears;
            Type = type;
        }

        public override string ToString() => $"Brand: {Brand}\r\n Number of gears: {NumberOfGears}\r\n Type: {Type}\r\n Color: {Color}\r\n Bike#: {bikeCount}\r\n\r\n *briing briiiing*{ClockBell}\r\n";
    }
}
