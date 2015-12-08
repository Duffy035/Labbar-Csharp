using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABB1_Hantera_varor
{
    class Plate : StockItem
    {
        private string typ;

        public string Type
        {
            get { return typ; }
            set
            {
                if (value.Equals("Flat") || value.Equals("Deep"))
                    typ = value;
                else
                    throw new Exception("Wrong plate type");
            }
        }

    }
}
