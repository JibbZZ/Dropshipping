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

        internal void Showproduct(Products product)
        {
            Console.Clear();

            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Description: {product.Description}, IsHot: {product.IsHot}, OnSale: {product.OnSale}, Image: {product.Image}, Weight: {product.Weight}, SellingPrice: {product.SellingPrice}, Manufacturer: {product.Manufacturer}");
            Console.ReadKey();
        }
    }
}