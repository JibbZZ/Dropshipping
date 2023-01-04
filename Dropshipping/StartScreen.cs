namespace DropShipping
{

    public class StartMenu
    {
        private Ui ui;

        public StartMenu(Ui ui)
        {
            this.ui = ui;
        }

        public void RunMainMenu()
        {
            string prompt = @"Welcome to the website! ";
            string[] options = { "Buy products", "About", "Shopping Cart", "Create Order", "Exit" };

            int _choice = new Menu(prompt, options).Run();

            switch (_choice)
            {
                case 0:
                    BuyProduct();
                    Console.Clear();
                    break;

                case 1:
                    About();
                    break;
                 case 2:
                    ui.ShowShoppingCart();
                    break; 
                case 3:
                    ui.CreateOrder();
                    break;
               
                case 4:
                    ExitGame();
                    break;
            }

        }
    public void BuyProduct()
        {
            Product product = ui.ChooseProduct();
            ui.Showproduct(product);
            //ui.CreateProduct(product);
        }

        public void ExitGame()
        {
            Console.Clear();
            Console.WriteLine("Thanks for visiting our website!");
            Thread.Sleep(500);
            Environment.Exit(0);
        }
    
        private void About()
        {
            Console.Clear();
            Console.WriteLine("This is a website were you can buy products, and we will ship them to you.");
            Console.WriteLine("There are many different products to choose from, and we have a wide range of products.");
            Console.WriteLine("Feel free to browse our website, and if you have any questions, please contact us. ");
            Console.ReadKey();
            Console.Clear();
            RunMainMenu();
        }
    }

}
