namespace Lab1.Model
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
            return $"LAGERVARA: { this.GetType().Name}, JUICETYP: {this.Type}, {base.ToString()}";
        }
    }
}
