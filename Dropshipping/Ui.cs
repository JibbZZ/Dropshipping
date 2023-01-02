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
        public Products ShoppingCart()
        {
            string[] options = ShopingCartProducts.Select(p => p.Name).ToArray();
            int selectedIndex = new Menu("Here is your items:", options).Run();
            return ShopingCartProducts[selectedIndex];
        }
        //show product in Shopping Cart
        public void ShowProductInShoppingCart(Products product)
        {
            DatabasManager db = new DatabasManager();
            db.InsertProducts(product);
            List<Products> products = db.GetProducts();
            products = ShopingCartProducts;
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Description: {product.Description}, IsHot: {product.IsHot}, OnSale: {product.OnSale}, Image: {product.Image}, Weight: {product.Weight}, SellingPrice: {product.SellingPrice}, Manufacturer: {product.Manufacturer}");
            Console.ReadKey();
        }
        //buy product
        public void CreateProduct(Products product)
        {
            DatabasManager db = new DatabasManager();
            db.InsertProducts(product);
            List<Products> products = db.GetProducts();
            Console.Clear();
            Console.WriteLine("You bought a product!");
            Console.ReadKey();
        }
         public void BuyProduct(Products product)
        {

           ShopingCartProducts.Add(product);
        }

        internal void Showproduct(Products product)
        {
            Console.Clear();

            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Description: {product.Description}, IsHot: {product.IsHot}, OnSale: {product.OnSale}, Image: {product.Image}, Weight: {product.Weight}, SellingPrice: {product.SellingPrice}, Manufacturer: {product.Manufacturer}");
            Console.ReadKey();
        }
        public void AddProduct(Products product)
        {
            DatabasManager db = new DatabasManager();
            db.InsertProducts(product);
        }
    }
}