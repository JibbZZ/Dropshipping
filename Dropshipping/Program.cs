namespace DropShipping
{
    public class Program
    {
        static void Main(string[] args)
        {
            DatabasManager db = new DatabasManager();
            Products products = new Products();
            Custumers custumers = new Custumers();
            DatabaseSeeder databaseSeeder = new DatabaseSeeder(db.connection);
            Order order = new Order();
            Supplier supplier = new Supplier();
            Payment payment = new Payment();
            new StartMenu().RunMainMenu();
            Ui ui = new Ui();

            
                ui.ChooseProduct();
            
           
             
            while (true)
            {
                

            
            }
        }
    }

}
