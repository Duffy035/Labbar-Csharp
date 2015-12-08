using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABB1_Hantera_varor
{
    class EcoStockItem : StockItem
    {
        private string mark;

        public string Mark
        {
            get { return mark; }
            set {
                if (value.Equals("Krav") || value.Equals("EG"))
                    mark = value;
                else
                    throw new Exception("Wrong maerkning!");
            }
        }
        public override string ToString() => $"{Mark}";
    }
}
