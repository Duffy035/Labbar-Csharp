using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABB1_Hantera_varor
{
    class StockItem
    {
        private int id;
        private int stockCount;
        private string name;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int StockCount
        {
            get { return stockCount; }
            set { stockCount = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public override string ToString() => $"{Id}, {StockCount}, {Name}";
    }
}
