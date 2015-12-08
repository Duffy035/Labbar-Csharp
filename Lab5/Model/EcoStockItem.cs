namespace Lab5.Model
{
    class EcoStockItem : StockItem
    {
        string mark;
        public string Mark
        {
            get { return mark; }
            set {
                if (value.Equals("Krav") || value.Equals("EG"))
                { 
                    mark = value;
                }
                else
                { 
                    throw new System.Exception("Fel märkning!");
                }
            }
        }
        public override string ToString()
        {
            return $"Juice name: {base.Name} med id: {base.Id} och märkning: {Mark} samt {base.StockCount} antal i lager";
        }
    }
}
