using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift30
{
    class Number
    {
        public int GetQuartNumber()
        {
            return (quartNumber / 4);
        }
        public void SetQuartNumber(int quartNumber)
        {
            this.quartNumber = quartNumber;
        }

        internal string printNumber()
        {
            return $"the quarter of {quartNumber} is {GetQuartNumber()}";
        }
    }
}