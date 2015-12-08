using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uppgift 1 - Sekvensboxar
            //Uppgift1_1();
            //Uppgift1_2();
            //Uppgift1_3();
            //Uppgift1_4();
            //Uppgift1_4alt();
            //Uppgift1_5();
            //Uppgift1_6();
            //Upgift 2 - Val och alternativ
            //Uppgift1_7();
            /*Uppgift1_8();*/  //OBS EJ KLAR
            //Uppgift1_10();
            //Uppgift1_11();
            //Uppgift1_12();
            /*Upgift 3 - Repetition/Iteration */
            Uppgift1_13();
            Console.ReadLine();
        }
        private static void Uppgift1_13()
        {
            Console.WriteLine("Skriv in tal");
            int tal = int.Parse(Console.ReadLine());
            if (tal == 0)
                Console.WriteLine("Då var det sluuuut");
            else
                int.Parse(Console.ReadLine());
        }

        private static void Uppgift1_12()
        {
            Console.WriteLine("Hur många enheter vill du köpa?");
            int amount = int.Parse(Console.ReadLine());
            int price = 200;
            int sum = price * amount;
            if (sum > 1000)
                Console.WriteLine($"Du har köpt {amount} och får rabatt på 10%, och du ska betala {sum}");
            else
                Console.WriteLine($"Du får ingen rabatt... för du har handlat för {sum}");
        }

        private static void Uppgift1_11()
        {
            Console.WriteLine("Skriv in ett tal: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("SKriv in ett annat tal: ");
            int tal2 = int.Parse(Console.ReadLine());
            if (tal1 % tal2 == 0)
                Console.WriteLine("Talet är jämnt delbart med det andra talet");
            else
                Console.WriteLine("Det första talet är inte jämnt delbart med det andra");
        }

        private static void Uppgift1_10()
        {
            while (true)
            {
                Console.WriteLine("Skriv ett tal: ");
                int tal1 = int.Parse(Console.ReadLine());
                if (tal1 % 2 == 0)
                    Console.WriteLine("Detta talet är jämnt");
                else
                    Console.WriteLine("Detta är inte jämnt");
            }
        }

        private static void Uppgift1_8()
        {
            Console.WriteLine("Skriv in ett tal: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ett till tal: ");
            int tal2 = int.Parse(Console.ReadLine());
        }

        private static void Uppgift1_7()
        {
            Console.WriteLine("Skriv in ett tal: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ett nytt tal:");
            int tal2 = int.Parse(Console.ReadLine());

            if (tal1 > tal2)
            {
                Console.WriteLine(tal1 + " är störst");
            }
            else
            {
                Console.WriteLine(tal2 + " är större än första talet");
            }
        }

        private static void Uppgift1_6()
        {
            Console.WriteLine("Ange ett värde för a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange ett värde för x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Beräkningen av ax3 + 7 = " + ((a * x) + 3 + 7));
        }

        private static void Uppgift1_5()
        {
            Console.WriteLine("Skriv in ett heltal (motsvarar kronor): ");
            double tal = int.Parse(Console.ReadLine());
            Console.WriteLine($"I pund och dollar blir detta tal: {tal / 12:F2} motsvarande {tal / 6:F2}" + " kr");   // <------ C# 6.0  
        }

        private static void Uppgift1_4alt()
        {

            Console.WriteLine("How many numbers would you like to calculate?");
            int iterations = int.Parse(Console.ReadLine());
            int[] numbers = new int[iterations];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Skriv ett tal:");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("the sum of the numbers are: {0} and medelvärdet is: {1}", sum, sum / numbers.Length);
        }

        private static void Uppgift1_4()
        {
            Console.WriteLine("Skriv in ett tal: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ett tal: ");
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ett tal: ");
            int tal3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ditt medelvärde är: " + (tal1 + tal2 + tal3) / 3);
        }

        private static void Uppgift1_3()
        {
            Console.WriteLine("Skriv in antal timmar:");
            int hours = int.Parse(Console.ReadLine());
            int minutes = hours * 60;
            int seconds = minutes * 60;
            Console.WriteLine("Detta är timmarna i minuter: " + minutes);
            Console.WriteLine("Detta är timmarna i sekunder: " + seconds);
        }

        private static void Uppgift1_2()
        {
            Console.WriteLine("Skriv in din försäljningssumma:");
            int sale = int.Parse(Console.ReadLine());
            int SALARY = 15000;
            int salestime = 2;

            Console.WriteLine("Lönesumman är: " + ((sale * salestime) + SALARY));
        }

        private static void Uppgift1_1()
        {
            Console.WriteLine("Skriv ett tal som motsvarar sidan på en kvadrat:");
            int tal = int.Parse(Console.ReadLine());
            Console.WriteLine("Arean är: " + tal * tal);
        }
    }
}

