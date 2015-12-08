using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABB1_Hantera_varor
{
    class Stock
    {
        StockItem[] stockItem = new StockItem[10];
        public StockItem this[int index]
        {
            get
            {
                if (index >= 0 && index < stockItem.Length)
                {
                    return this.stockItem[index];
                }
                else
                {
                    throw new Exception("Invalid get range");
                }
            }
          private set
            {
                if (index >= 0 && index < stockItem.Length)
                {
                    this.stockItem[index] = value;
                }
                else
                {
                    throw new Exception("Invalid set range");
                }                
            }
        }

        public void AddItem(StockItem item)
        {
            bool added = false;
             
            for (int i = 0; i < stockItem.Length; i++)
            {
                if (stockItem[i] != null)
                {
                    this[i] = item;
                    added = true;
                }
            }

            if (!added)
            {
                throw new Exception("The stock is full!");
            }

        }
        public StockItem GetItem(int itemId)
        {
            return this[itemId];
        }
    }
}
