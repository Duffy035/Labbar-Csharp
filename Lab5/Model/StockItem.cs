namespace Lab5.Model
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
            set
            {
                if (value > 0 && value < int.MaxValue)
                {
                    stockCount = value;
                }
                else
                {
                    throw new System.Exception("Måste vara ett positivt värde");
                }
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return $"Lagervara med id: {this.Id} och namn {this.Name} har {this.StockCount} antal på lager";
        }
    }
}
