namespace Lab5.Model
{
    class Juice : EcoStockItem
    {
        string type;
        public string Type
        {
            get { return type; }
            set {
                if (value.Equals("Apple") || value.Equals("Orange"))
                {
                    type = value;
                }
                else
                {
                    throw new System.Exception("Fel juicetyp!");
                }
            }
        }
        public override string ToString()
        {
            return $@"Juice name: {base.Name} med id: {base.Id} och märkning: {base.Mark} med typen: {this.Type} samt {base.StockCount} antal i lager";
        }
    }
}
