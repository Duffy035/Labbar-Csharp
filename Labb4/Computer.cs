using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    class Computer
    {
        private string cpu;
        private string gpu;
        private string motherboard;
        private int memoryAmount;
        private int numberOfFans;
        private double ghz;


        public string Cpu
        {
            get { return cpu; }
            set
            {
                if (value != null)
                    cpu = value;
                else
                    throw new Exception("You must define a cpu type");
            }
        }

        public string Gpu
        {
            get { return gpu; }
            set
            {
                if (value != null)
                    gpu = value;
                else
                    throw new Exception("You dont have a gpu in this day and age?");
            }
        }

        public string Motherboard
        {
            get { return motherboard; }
            set
            {
                if (value != null)
                    motherboard = value;
                else
                    throw new Exception("Your computer must have a motherboard");
            }
        }

        public int MemoryAmount
        {
            get { return memoryAmount; }
            set
            {
                if (value > 0)
                    memoryAmount = value;
                else if (value > 4 && value == 8)
                    Console.WriteLine("You have a reasonable amount of memory");
                else if (value > 8 && value > 16 && value <= 32)
                    Console.WriteLine("Your computer have alot of memory!");
            }
        }
        public int NumberOfFans
        {
            get { return numberOfFans; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Is the computer water cooled?");
                else if (value > 2 && value <= 3)
                    Console.WriteLine("Your computers temperature should be cool");
                else if (value > 4)
                    Console.WriteLine("Your computer must be cooler than the North Pole! Is it OC:ed?");
                else
                    numberOfFans = value;
            }
        }

        public double Ghz
        {
            get { return ghz; }
            set
            {
                if (value > 0)
                    ghz = value;
                else if (value > 2.0 && value <= 2.2)
                    Console.WriteLine("Your Ghz is pretty low");
                else if (value > 2.2 && value > 3.0 && value <= 4.5)
                    Console.WriteLine("You must have a powerful cpu!");
            }
        }
        public Computer()
        {
            Cpu = "Core i5";
            Gpu = "Geforce 780";
            Motherboard = "ASUS 555-X7";
            MemoryAmount = 8;
            NumberOfFans = 2;
            Ghz = 3.2;
        }
        public Computer(string cpu, string gpu, string motherboard, int memoryAmount, int numberOfFans, double ghz) : this()
        {
            Cpu = cpu;
            Gpu = gpu;
            Motherboard = motherboard;
            MemoryAmount = memoryAmount;
            NumberOfFans = numberOfFans;
            Ghz = ghz;
        }
        public override string ToString() => $"Cpu: {Cpu}\r\n Gpu: {Gpu}\r\n Motherboard. {Motherboard}\r\n Amount of RAM: {MemoryAmount}\r\n Number of fans: {NumberOfFans}\r\n Processor Ghz: {Ghz}\r\n";
    }
}
