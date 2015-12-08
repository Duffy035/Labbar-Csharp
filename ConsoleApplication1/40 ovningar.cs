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
            //Uppgift1_13();
            /* Uppgift1_14();*/  //Se 'Uppg14'
            //Uppgift1_15();
            //Uppgift1_16();
            //Uppgift1_17();
            //Uppgift1_18();
            //Uppgift1_19();
            //Uppgift1_20();
            //Uppgift1_23();
            //Uppgift1_24();
            //Uppgift1_25();
            //Uppgift1_26();
            //Uppgift 3 - Extra övningar till algoritmer
            //Uppgift1_31();
            //Uppgift1_33();
            //Uppgift1_37();
            //Uppgift1_38();
            //Uppgift1_39();
            Uppgift1_40();
            Console.ReadLine();
        }

        private static void Uppgift1_40()
        {
            Console.WriteLine("Skriv in ett tal mellan 0-9");
            int number = int.Parse(Console.ReadLine());

            if (number > 0 && number <= 9 && number != 5)
            {
                Console.WriteLine("Ditt tal ligger mellan 0-9");
            }
            else if (number == 5)
            {
                Console.WriteLine("Ditt nummer är fem");
            }
        }

        private static void Uppgift1_39()
        {
            Console.WriteLine("Skriv in ett tal");
            int number = int.Parse(Console.ReadLine());

            if (number > 0 && number <= 9)
            {
                Console.WriteLine($"{number} är mellan 0-9");
            }
            else
            {
                Console.WriteLine("Ditt tal är inte mellan 0-9");
            }
        }

        private static void Uppgift1_38()
        {
            Console.WriteLine("Skriv in ett tal:");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("Talet är positivt");
            }
            else
            {
                Console.WriteLine("Talet är negativt");
            }
        }

        private static void Uppgift1_37()
        {
            int x, y = 0;
            Console.WriteLine("Ange ett värde för I (måste vara heltal!)");
            int I = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange ett värde för K (måste också vara heltal");
            int K = int.Parse(Console.ReadLine());

            if (I > (5 + K))
            {
                x = 2;
                Console.WriteLine(x);
            }
            else
            {
                y = 5;
                Console.WriteLine(y);
            }
        }

        private static void Uppgift1_33()
        {
            Console.WriteLine("Skriv in temeperatur (anges i Fahrenheit):");
            double fahrenheitTemperature = double.Parse(Console.ReadLine());

            double celsius = ((fahrenheitTemperature - 32) * (5.0 / 9.0));  //F = 9 C / 5 + 32    och    C = (number  -  32)  *  5/9
            Console.WriteLine(celsius);
        }

        private static void Uppgift1_31()
        {
            Console.WriteLine("Skriv in ett tal:");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ett nytt tal:");
            int tal2 = int.Parse(Console.ReadLine());

            int sum = tal1 * tal2;
            Console.WriteLine($"Summan av talen är: {sum}");
        }

        private static void Uppgift1_26()
        {
            Console.WriteLine("Skriv in täljaren");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in nämnaren");
            int secondNumber = int.Parse(Console.ReadLine());

            while (secondNumber == 0)
            {
                Console.WriteLine("Nämnaren får inte vara 0. SKriv ett nytt nummer");
                secondNumber = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{firstNumber}/{secondNumber} = {(float)firstNumber / (float)secondNumber}");
        }

        private static void Uppgift1_25()
        {
            int[] thisArray = {1, -2, -3, 4, 5, -1, 2, 3, 4, 5, -1, -2, -3, 4, 5, -1, 2, -3, 4, 5, -1, 2, 3, 4, 5, -1, -2, -3, -4, 5, -1, -2, -3, 4, 5, -1, -2, -3, 4, 5, 1, -2, -3, 4, 5, -1, -2, -3, 4, 5};
            int positiveNumbers = 0;
            for (int i = 0; i < 50; i++)
            {
                if (thisArray[i] > 0)
                {
                    positiveNumbers++;
                }
            }
            Console.WriteLine($"This is the amount of positive numbers: {positiveNumbers}");
        }

        private static void Uppgift1_24()
        {
            int[] thisArray = new int[50];
            for (int i = 0; i < thisArray.Length; i++)
            {
                thisArray[i] = i;
                if (i % 2 == 0)
                {
                    Console.WriteLine("Summan adderat med 2 blir: " + (thisArray[i] + 2));
                }
                else
                {
                    Console.WriteLine(thisArray[i]);
                }
            }
        }

        private static void Uppgift1_23()
        {
            int[] thisArray = new int[50];
            for (int i = 0; i < thisArray.Length; i++)
            {
                thisArray[i] = i;
                Console.WriteLine("Varje enskilt tal i vekorn multiplicerat med 2: " + (thisArray[i] * 2));
            }
        }

        private static void Uppgift1_20()
        {
            List<int> helTal = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Skriv in ett tal: ");
                helTal.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"Det totala värdet av talen är{helTal.Sum()}");
            Console.ReadLine();
        }

        private static void Uppgift1_19()
        {
            for (int i = 0; i < 50; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        private static void Uppgift1_17()
        {
            int kvadrat;
            for (int i = 1; i < 10; i++)
            {
                kvadrat = i * i;
                Console.WriteLine(kvadrat);
            }
            Console.ReadKey();
        }

        private static void Uppgift1_16()
        {
            char character;
            do
            {
                Console.WriteLine("Skriv in en siffra (tryck '*' för att avsluta):");
                character = Console.ReadKey().KeyChar;
                Console.WriteLine($"\nBokstaven är: \'{character}\'");
            } while (character != '*');
        }

        private static void Uppgift1_15()
        {
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        private static void Uppgift1_13()
        {
            Console.WriteLine("Skriv in ett tal");
            int tal = int.Parse(Console.ReadLine());
            while (tal < 0)
            {
                Console.WriteLine("Du skrev 0 - nu är det slut");
                tal++;
            }
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

