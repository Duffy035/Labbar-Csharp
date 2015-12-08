using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABB1_Hantera_varor
{
    class Juice : EcoStockItem
    {
        private string type;

        public string Type
        {
            get { return type; }
            set {
                if (value.Equals("Apple") || value.Equals("Orange"))
                    type = value;
                else
                    throw new Exception("Wrong juice!");
            }
        }
        public override string ToString() => $"{Type}";
    }
}
