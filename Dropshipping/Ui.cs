using Dapper;
using MySqlConnector;

namespace DropShipping
{


    public class Ui
    {
          List<Products> ShopingCartProducts = new List<Products>();
        //choose product
        public Products ChooseProduct()
        {
            DatabasManager db = new DatabasManager();
            Console.Clear();
            List<Products> products = db.GetProducts();
            string[] options = products.Select(p => p.Name).ToArray();
            int selectedIndex = new Menu("Choose a product!", options).Run();
            Console.Clear();
            return products[selectedIndex];
        }
         
        
        //buy product
       /*  public void CreateProduct(Products product)
        {
            DatabasManager db = new DatabasManager();
            db.InsertProducts(product);
            List<Products> products = db.GetProducts();
            Console.Clear();
            Console.WriteLine("You bought a product!");
            Console.ReadKey();
        } */
       

        internal void Showproduct(Products product)
        {
            Console.Clear();
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Description: {product.Description}, IsHot: {product.IsHot}, OnSale: {product.OnSale}, Image: {product.Image}, Weight: {product.Weight}, SellingPrice: {product.SellingPrice}, Manufacturer: {product.Manufacturer}");
            Console.WriteLine("Do you want to buy this product? (y/n)");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
               AddProductToShopingCart(product);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You didn't buy the product!");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
        public void AddProductToShopingCart(Products product)
        {
            ShopingCartProducts.Add(product);
            Console.Clear();
            Console.WriteLine("You bought a product!");
            Console.ReadKey();
        }
        
    }
}