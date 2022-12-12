using Dapper;
using MySqlConnector;

namespace DropShipping
{


    public class Ui
    {

        private Products ChosenProduct()
        {
            
            string prompt = "Choose a product!";
            string[] options = new string[] { "Choose", "Exit" };

            int selectedIndex = new Menu(prompt, options).Run();

            DatabasManager db = new DatabasManager();
            Products products = new Products();
            db.InsertProducts(products);
            return products;


        }

    }
}