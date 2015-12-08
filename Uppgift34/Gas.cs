using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift34
{
    class Gas
    {
        int totalLitre;
        int pricePerLitre;
        double discount;

        public void SetTotalLitre(int totalLitre)
        {
            this.totalLitre = totalLitre;
        }
        public void SetPricePerLitre(int pricePerLitre)
        {
            this.pricePerLitre = pricePerLitre;
        }
        public void SetDiscount (double discount)
        {
            this.discount = discount;
        }
        double GetGasPrice()
        {
            return totalLitre * pricePerLitre * discount;
        }

        internal string PrintGasPrice()
        {
            return $"The price for you is: {this.GetGasPrice():C}";
        }
    }
}
