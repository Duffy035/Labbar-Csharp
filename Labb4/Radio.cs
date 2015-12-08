using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    class Radio
    {
        private int volume;
        private bool isOff;
        private double frequence;

        public int Volume
        {
            get { return volume; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("I can't hear anything...");
                else if (value >= 10)
                    Console.WriteLine("Turn the volume down!");
                else
                    volume = value;
            }
        }
        public bool IsOff
        {
            get { return isOff; }
            set
            {
                isOff = value;
            }
        }

        public string OnOffState
        {
            get
            {
                return IsOff ? "Off" : "On";
            }

            //Erik:
            //public override string ToString()
            //{
            //    bool isOn = true;

            //    return isOn ? "På" : "Av";
            //}
        }

        public double Frequence
        {
            get { return frequence; }
            set
            {
                if (value > 0 && value <= 100)
                    frequence = value;
                else if (value >= 150)
                    Console.WriteLine("Myabe you'll find a radio station from another country?");
                else
                    Console.WriteLine("OK, you should find some kind of radio station!?");
            }
        }
        public static int InstanceCount
        {
            get;
            private set;
        }

        static Radio()
        {
            InstanceCount = 0;
        }
        public Radio()
        {
            Volume = 5;
            Frequence = 95.6;
            IsOff = true;
            InstanceCount++;
        }

        public Radio(int volume, double frequence) : this()
        {
            Volume = volume;
            Frequence = frequence;
        }
        public Radio(int volume, bool isOff, double frequence) : this(volume, frequence)
        {
            IsOff = isOff;
        }
        public override string ToString()
        {
            return $"The radio volume is set to {Volume}.\r\n The radio is {OnOffState}, with a frequence off: {Frequence}\r\n This is radio number: {InstanceCount}\r\n";
        }
    }
}
