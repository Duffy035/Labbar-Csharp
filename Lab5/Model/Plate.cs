namespace Lab5.Model
{
    class Plate : StockItem
    {
        string type;
        public string Type
        {
            get { return type; }
            set
            {
                if (value.Equals("Flat") || value.Equals("Deep"))
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
            return $"Tallriken är av typen: {this.Type}";
        }
    }
}
