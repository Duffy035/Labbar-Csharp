using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Min mainmetod
namespace Labb3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uppgift1();
            //Uppgift2();
            //Uppgift3();
            //Uppgift4();
            Uppgift5();

        }

        private static void Uppgift5()
        {
            Engine porcheEngine = new Engine();
            Console.WriteLine("How many gears does your car engine have?");
            int amountOfGears = int.Parse(Console.ReadLine());
            porcheEngine.SetGears(amountOfGears);
            Console.WriteLine("What is its horsepowers?");
            int horsepowers = int.Parse(Console.ReadLine());
            porcheEngine.SetHorespowers(horsepowers);
            Console.WriteLine("What is the topspeed?");
            int engineTopspeed = int.Parse(Console.ReadLine());
            porcheEngine.SetTopSpeed(engineTopspeed);
            Console.WriteLine("How many cylinders does the engine have?");
            int cylindersAmount = int.Parse(Console.ReadLine());
            porcheEngine.SetCylinders(cylindersAmount);

            Console.WriteLine($"Your car has {porcheEngine.GetGears()} gears, {porcheEngine.GetHorsepowers()} horsepowers, and {porcheEngine.GetTopSpeed()} km/h in topspeed, and{porcheEngine.GetCylinders()} cylinders");

            Car porche = new Car();
            string carColor = "jet black";
            porche.SetColor(carColor);
            porche.SetEngineType(porcheEngine);
            Console.WriteLine($"Your cars color is: {porche.GetColor()} .");

            Console.WriteLine(porche.GetEngine().PrintEngine());

            Engine bikeEngine = new Engine();
            Console.WriteLine("How many gears does your bike engine have?");
            int bikeAmountOfGears = int.Parse(Console.ReadLine());
            bikeEngine.SetGears(bikeAmountOfGears);
            Console.WriteLine("What is its horsepowers?");
            int bikeHorsepowers = int.Parse(Console.ReadLine());
            bikeEngine.SetHorespowers(bikeHorsepowers);
            Console.WriteLine("What is the topspeed?");
            int bikeEngineTopspeed = int.Parse(Console.ReadLine());
            bikeEngine.SetTopSpeed(bikeEngineTopspeed);
            Console.WriteLine("How many cylinders does the engine have?");
            int bikeCylindersAmount = int.Parse(Console.ReadLine());
            bikeEngine.SetCylinders(bikeCylindersAmount);

            Bike motorbike = new Bike();
            string bikeColor = "yellow";
            motorbike.SetColor(bikeColor);
            motorbike.SetEngineType(bikeEngine);
            Console.WriteLine($"Your bikes color is: {motorbike.GetColor()} .");

            Console.WriteLine(motorbike.GetEngine().PrintEngine());


            Console.WriteLine($"Your car has {porche.GetColor()} color, {porche.GetEngine().GetHorsepowers()} horsepowers, {porche.GetEngine().GetGears()} gears, {porche.GetEngine().GetCylinders()} cylinders, with a topspeed of: {porche.GetEngine().GetTopSpeed()}");

            Console.WriteLine($"\r\nYour bike has {motorbike.GetColor()} color, {motorbike.GetEngine().GetHorsepowers()} horsepowers, {motorbike.GetEngine().GetGears()} gears, {motorbike.GetEngine().GetCylinders()} cylinders, with a topspeed of: {motorbike.GetEngine().GetTopSpeed()}");
        }

        private static void Uppgift4()
        {
            //Circle myCircle = new Circle();
            //myCircle.SetDiameter(10);

            //Point myPoint = new Point();
            //myPoint.SetX(8);
            //myPoint.SetY(10);
            //myCircle.SetCenter(myPoint);

            //Console.WriteLine("The X point is: " + myCircle.GetCenter().GetX());
            //Console.WriteLine("The Y point is: " + myCircle.GetCenter().GetY());
            //Console.WriteLine("The diameter is: " + myCircle.GetDiameter());
            //Console.WriteLine("The circumference is: " + myCircle.GetCircumference());

            Random random = new Random();
            Circle[] myCircle = new Circle[1000];
            for (int i = 0, j = 369; i < myCircle.Length; i++, j += 7)  //j slumpar fram ett nummer.
            {
                myCircle[i] = new Circle();
                myCircle[i].SetDiameter(j);     //varje ny cirkel får en slumpad diameter - j
                var newPoint = new Point();
                newPoint.SetX(random.Next(0, 45));      //Sätter ett slumpat x mellan 0-45
                newPoint.SetY(random.Next(0, 45));      //Sätter ett slumpat y mellan 0-45
                myCircle[i].SetCenter(newPoint);        //Sätter en punkt i varje ny cirkel
            }
            foreach (var circle in myCircle)
            {
                //Console.WriteLine("The X point is: " + circle.GetCenter().GetX());
                //Console.WriteLine("The Y point is: " + circle.GetCenter().GetY());
                //Console.WriteLine("The diameter is: " + circle.GetDiameter());
                //Console.WriteLine("The circumference is: " + circle.GetCircumference());
                Console.WriteLine(circle.GetCircleString());
                Console.WriteLine();
            }
        }

        private static void Uppgift3()
        {
            Point point = new Point();
            Console.WriteLine("Type a value for X: ");
            int myX = int.Parse(Console.ReadLine());
            point.SetX(myX);
            Console.WriteLine("Type a value for Y: ");
            int myY = int.Parse(Console.ReadLine());
            point.SetY(myY);
            Console.WriteLine("The value of X is: " + point.GetX() + " and the value of Y is: " + point.GetY());
        }

        private static void Uppgift2()
        {
            Circle circle = new Circle();  //skapar ny instans av circle
            Console.WriteLine("Type the diameter for the circle");  //ber anv. skriva in ett värde
            double circleDiameter = double.Parse(Console.ReadLine());   // sparar värdet i en variabel
            circle.SetDiameter(circleDiameter);         //sätter värdet som skrev in i SetDiameter
            Console.WriteLine("The circles diameter is: " + circle.GetDiameter());  //Skriver ut cirkelns diameter
            Console.WriteLine("The circles circumference is: " + circle.GetCircumference());  //Skriver ut GetCircumference
        }

        private static void Uppgift1()
        {
            Person person = new Person();
            Console.WriteLine("Type a name:");
            string name = Console.ReadLine();
            person.SetName(name);
            Console.WriteLine(person.GetName());

            Person person2 = new Person();
            Console.WriteLine("Type another name:");
            person2.SetName("Namet är: " + person2.GetName());
            Console.ReadLine();

            Person person3 = new Person();
            Console.WriteLine("Type yet another name:");
            person3.SetName("Detta namnet är: " + person3.GetName());
            Console.ReadLine();
        }
    }
}
