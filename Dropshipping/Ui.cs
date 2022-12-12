using Dapper;
using MySqlConnector;

namespace DropShipping
{


    public class Ui
   {

     public Products ChooseProduct()
        {
            DatabasManager db = new DatabasManager();
           Console.Clear();
           List<Products> products = db.GetProducts();

           string[] options = products.Select(p => p.Name).ToArray();
           int selectedIndex = new Menu("Choose a product!", options).Run();
           return products[selectedIndex];
        }
   }
}