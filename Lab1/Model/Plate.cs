namespace Lab1.Model
{
    class Plate : StockItem
    {
        string type;
        public string Type
        {
            get { return type; }
            set
            {
                if (value.ToLower().Equals("flat") || value.ToLower().Equals("deep"))
                {
                    type = value;
                }
                else
                { 
                    throw new System.Exception("Fel tallrikstyp");
                }
            }
        }
        public override string ToString()
        {
            return $"LAGERVARA: {this.GetType().Name}, TYP: {this.Type}, {base.ToString()}";
        }
    }
}
