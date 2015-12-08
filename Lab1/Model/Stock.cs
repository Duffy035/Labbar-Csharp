namespace Lab1.Model
{
    class Stock
    {
        //Indexer är inte kompatibel med readonly:
        //Readonly arbetar på fältnivå.
        //Indexer arbetar på egenskapsnivå.

        //Storing field
        StockItem[] stockItem = new StockItem[10];

        //Indexer
        public StockItem this[int index]
        {
            get
            {
                try
                {
                    return stockItem[index];
                }
                catch (System.Exception)
                {
                    throw new System.Exception("Du är utanför varulagrets kapacitet");
                }
            }
            private set
            {
                try
                {
                    this.stockItem[index] = value;
                }
                catch (System.Exception)
                {
                    throw new System.Exception("Ditt sättindex är utom räckvidd"); //Customize original exception
                }               
            }
        }

        //Accessors
        public void AddItem(StockItem item)
        {
            bool added = false;
             
            for (int i = 0; i < stockItem.Length; i++)
            {
                if (stockItem[i] == null && !added)
                {
                    this[i] = item;
                    added = true;
                }
            }

            if (!added)
            {
                throw new System.Exception("Lagret är fullt!");
            }
        }
        public StockItem GetItem(int itemId)
        {
            return this[itemId];
        }
        public int GetLength()
        {
            return this.stockItem.Length;
        }
        public bool HasItems()
        {
            int num = 0;

            for (int i = 0; i < this.stockItem.Length; i++)
            {
                if (this.stockItem[i] != null)
                {
                    num++;
                }
            }

            if (num > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
