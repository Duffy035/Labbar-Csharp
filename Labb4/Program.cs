using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uppgift1();
            //Uppgift2_3_4_5();
            ////Uppgift6();
            Uppgift6_egen();

        }

        private static void Uppgift6_egen()
        {
            Computer computer = new Computer();
            Console.WriteLine(computer);

            Computer gaming = new Computer() { Cpu = "Core i7", Gpu = "Geforce 980Ti", Motherboard = "ASRock superduper", MemoryAmount = 32, Ghz = 4.0, NumberOfFans = 4 };
            Console.WriteLine(gaming);

            Computer office = new Computer() { Cpu = "Core i3", Gpu = "integrated", Motherboard = "Gigabyte 400", MemoryAmount = 4, Ghz = 2.2, NumberOfFans = 1 };
            Console.WriteLine(office);

            Console.ReadLine();
        }


        private static void Uppgift6()
        {
            Bike mountainbike = new Bike();
            Console.WriteLine(mountainbike);

            Bike ladiesbike = new Bike() { Brand = "Trecc" };
            Console.WriteLine(ladiesbike);

            Bike childbike = new Bike() { Brand = "Nishiki", NumberOfGears = 3 };
            Console.WriteLine(childbike);

            Bike randombike = new Bike() { Brand = "Monark", NumberOfGears = 16, Type = "City bike", Color = "Blue", ClockBell = true };
            Console.WriteLine(randombike);
            Console.ReadLine();
        }

        private static void Uppgift2_3_4_5()
        {
            //3
            Radio pocketradio = new Radio();
            Console.WriteLine(pocketradio);


            //4
            Radio pocketradio2 = new Radio();
            Radio pocketradio3 = new Radio();
            Radio pocketradio4 = new Radio();
            Radio pocketradio5 = new Radio(9, true, 45.4 );
            Console.WriteLine(Radio.InstanceCount);


            //5
            Radio pocketRadioObjInitilized = new Radio() { Volume = 2, Frequence = 65.7 };
            Console.WriteLine(pocketRadioObjInitilized);

            Radio pocketRadioObjInitilized2 = new Radio() { Volume = 9, Frequence = 99.9, IsOff = false };
            Console.WriteLine(pocketRadioObjInitilized2);

            Radio pocketRadioObjInitilized3 = new Radio() { Volume = 4, Frequence = 56.9, IsOff = false };
            Console.WriteLine(pocketRadioObjInitilized3);
            Console.ReadLine();
        }

        private static void Uppgift1()
        {
            Car kombi = new Car("kombi");
            Console.WriteLine(kombi);

            Car suv = new Car("suv");
            Console.WriteLine(suv);
        }
    }
}


//Eriks:
//try
//{

//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
