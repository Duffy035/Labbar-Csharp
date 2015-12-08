namespace Lab5
{
    class StockApp
    {
        Model.Stock stock = new Model.Stock();

        public void Start()
        {
            //Initiera menyval
            IO.Output("Menyalternativ:");
            string option = IO.Input(null, new string[] { "1: Skapa vara", "2: Inventera vara", "3: Lista varor", "4: Avsluta" });

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
            string option = IO.Input(null, new string[] { "1: Juice", "2: Tallrik", "3: Ekovara" });

            switch (option)
            {
                case "1":
                    item = AddJuice();
                    break;
                case "2":
                    item = AddPlate();
                    break;
                case "3":
                    item = AddEco();
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
            //Starta om i fall lagret är tomt
            if (!this.stock.HasItems())
            {
                IO.StartOver("Lagret är tomt...");
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

            IO.StartOver(this.stock.GetItem(int.Parse(index)).ToString());
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
                        IO.Output(i + ": " + this.stock[i].ToString());
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
            Model.Juice juice = new Model.Juice();
            System.Console.WriteLine("Är juice Krav eller eco-märkt? Välj 1 för Krav, välj 2 för Eco");
            int userInput;
            int.TryParse(System.Console.ReadLine(), out userInput);
            if (userInput == 1)
                juice.Type = "Kravmärkt";
            else if (userInput == 2)
                juice.Type = "Eco-märkt";

            return juice;

        }
        Model.StockItem AddPlate()
        {
            //vill lägga till tallrik
            //fråga anv om tallriken är flat eller deep
            //addera anv input till tallriken
            //returnera tallriken

            Model.Plate plate = new Model.Plate();
            System.Console.WriteLine("Är tallriken flat eller deep? Välj 1 för flat eller 2 för deep");
            int userInput;
            int.TryParse(System.Console.ReadLine(), out userInput);
            if (userInput == 1)
                plate.Type = "Flat";
            else if (userInput == 2)
                plate.Type = "Deep";

            return plate;

        }
        Model.StockItem AddEco()
        {
            Model.EcoStockItem ecostockitem = new Model.EcoStockItem();
            System.Console.WriteLine("Är varan eco-märkt? 1: Ja, 2: Nej");
            int userInput;
            int.TryParse(System.Console.ReadLine(), out userInput);
            if (userInput == 1)
                ecostockitem.Mark = "Eco-märkt";
            else if (userInput == 2)
                ecostockitem.Mark = "Inte eco-märkt";
            return ecostockitem;

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
