namespace Lab1
{
    class StockApp
    {
        Model.Stock stock = new Model.Stock();

        public void Start()
        {
            //Initiera menyval
            IO.Output("Menyalternativ:");
            string option = IO.Input( new string[] { "1: Skapa vara", "2: Inventera vara", "3: Lista varor", "4: Avsluta" });

            //Selektera menyval
            switch (option)
            {
                case "1":
                    OptionAdd();
                    break;
                case "2":
                    OptionUpdate();
                    break;
                case "3":
                    OptionList();
                    IO.StartOver();
                    Start();
                    break;
                case "4":
                    System.Environment.Exit(0);
                    break;
                default:
                    IO.StartOver("Fel menyval, startar om...");
                    Start();
                    break;
            }
        }
        //Options
        void OptionAdd()
        {
            //Initiera varuval och tilldela vara
            Model.StockItem item = new Model.StockItem();
            IO.Output("Välj vara:");
            string option = IO.Input(new string[] { "1: Juice", "2: Tallrik" });

            switch (option)
            {
                case "1":
                    item = AddJuice();
                    break;
                case "2":
                    item = AddPlate();
                    break;
                default:
                    IO.StartOver("Fel menyval, startar om...");
                    OptionAdd();
                    break;
            }

            //Tillsätt generiska attribut
            AddGenerics(item);

            //Spara upp på lagret och avsluta
            this.stock.AddItem(item);
            IO.StartOver(item.ToString());
            Start();
        }
        void OptionUpdate()
        {
            //Starta om i fall lagret är tomt...
            if (!this.stock.HasItems())
            {
                IO.StartOver("Lagret är tomt....");
                Start();
            }

            //Annars visa lagervaror och uppdatera saldo
            OptionList();
            string index = IO.Input("Välj vara att uppdatera genom index (nummer)");
            string number = IO.Input("Välj nytt saldo (nummer)");

            try
            {
                if (this.stock[int.Parse(index)] != null)
                {
                    this.stock.GetItem(int.Parse(index)).StockCount = int.Parse(number);
                }
                else
                {
                    throw new System.Exception("Varan finns inte på lager");
                }
            }
            catch (System.FormatException)
            {
                IO.StartOver("Endast siffror är tillåtna...");
                OptionUpdate();
            }
            catch (System.Exception e)
            {
                IO.StartOver(e.Message + " försök igen...");
                OptionUpdate();
            }

            IO.StartOver("Du har uppdaterat: " + this.stock.GetItem(int.Parse(index)).ToString());
            Start();
        }
        void OptionList()
        {
            if (this.stock.HasItems())
            {
                IO.Output("Lagerförda varor:");
                for (int i = 0; i < this.stock.GetLength(); i++)
                {
                    if (this.stock[i] != null)
                    {
                        string item = this.stock[i].ToString();

                        if (this.stock[i] is Model.EcoStockItem)
                        {
                            item += " och är en ekovara";
                        }

                        IO.Output(i + ": " + item);
                    }
                }
            }
            else
            {
                IO.Output("Lagret är tomt...");
            }
        }
        //Items
        Model.StockItem AddJuice()
        {
            //Skapa juice
            Model.Juice juice = new Model.Juice();

            IO.Output("Välj märkning");
            string optionMark = IO.Input(new string[] { "1: EG", "2: Krav" });
            switch (optionMark)
            {
                case "1":
                    juice.Mark = "EG";
                    break;
                case "2":
                    juice.Mark = "Krav";
                    break;
                default:
                    IO.StartOver("Ange val igen...");
                    AddJuice();
                    break;
            }

            IO.Output("Välj typ");
            string optionType = IO.Input(new string[] { "1: Apple", "2: Orange" });
            switch (optionType)
            {
                case "1":
                    juice.Type = "Apple";
                    break;
                case "2":
                    juice.Type = "Orange";
                    break;
                default:
                    IO.StartOver("Ange val igen...");
                    AddJuice();
                    break;
            }

            return juice;
        }
        Model.StockItem AddPlate()
        {
            //Skapa tallrik
            Model.Plate plate = new Model.Plate();

            IO.Output("Välj typ");
            string optionType = IO.Input(new string[] { "1: Flat", "2: Deep" });
            switch (optionType)
            {
                case "1":
                    plate.Type = "Flat";
                    break;
                case "2":
                    plate.Type = "Deep";
                    break;
                default:
                    IO.StartOver("Ange val igen...");
                    AddPlate();
                    break;
            }

            return plate;
        }
        Model.StockItem AddGenerics(Model.StockItem item)
        {
            //Hantera gemensamma attribut: id, namn, stockCount
            try
            {
                item.Id = int.Parse(IO.Input("Ange artikelnummer (nummer):"));
                item.Name = IO.Input("Ange namn:");
                item.StockCount = int.Parse(IO.Input("Ange antal i lager (nummer):"));
            }
            catch (System.FormatException)
            {
                IO.StartOver("Endast siffror är tillåtna, startar om...");
                AddGenerics(item);
            }
            catch (System.Exception e)
            {
                IO.StartOver(e.Message + ", startar om...");
                AddGenerics(item);
            }

            return item;
        }
    }
}
