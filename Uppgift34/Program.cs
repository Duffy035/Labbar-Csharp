using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift34
{
    class Program
    {
        static void Main(string[] args)
        {
            Gas gasPrice = new Gas();
            Console.WriteLine("How many liters do you pump?");
            gasPrice.SetTotalLitre(int.Parse(Console.ReadLine()));
            Console.WriteLine("What is the price/liter?");
            gasPrice.SetPricePerLitre(int.Parse(Console.ReadLine()));
            Console.WriteLine("If you have a discount, please type in the amount of discount you have. (Type 1 if there is no discount)");  //discount is broken
            gasPrice.SetDiscount(double.Parse(Console.ReadLine()));
            Console.WriteLine(gasPrice.PrintGasPrice());
        }
    }
}
