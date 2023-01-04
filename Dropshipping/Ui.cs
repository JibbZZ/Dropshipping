using Dapper;
using MySqlConnector;

namespace DropShipping
{


    public class Ui
    {
        
        //choose product
        public Product ChooseProduct()
        {
            DatabasManager db = new DatabasManager();
            Console.Clear();
            List<Product> products = db.GetProducts();
            string[] options = products.Select(p => p.Name).ToArray();
            int selectedIndex = new Menu("Choose a product!", options).Run();
            Console.Clear();
            return products[selectedIndex];
        }
         
        
        //buy product
          public void CreateProduct(Product product)
        {
            DatabasManager db = new DatabasManager();
            List<Product> products = db.GetProducts();
            Console.WriteLine(product.Name);
            Console.Clear();
            Console.WriteLine("You bought a product!");
            Console.ReadKey();
        }  
        //create product
      
        //create order
        public void CreateOrder()
        {
            DatabasManager db = new DatabasManager();
            Order order = new Order();
            foreach (var item in ShoppingCart.Items)
            {
                order.Products.Add(item);
            }
            db.InsertOrder(order);
            Console.Clear();
            Console.WriteLine("You bought a product!");
            Console.ReadKey();
            }
       

         internal void Showproduct(Product product)
        {
            DatabasManager db = new DatabasManager();
            Console.Clear();
            Console.WriteLine(@$"Name: {product.Name}
            Price: {product.Price}
            Description: {product.Description}
            IsHot: {product.IsHot}
            OnSale: {product.OnSale}
            Image: {product.Image}
            Weight: {product.Weight}
            SellingPrice: {product.SellingPrice}
            Manufacturer: {product.Manufacturer}");
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
        
        } 
         public void AddProductToShopingCart(Product product)
        {
            ShoppingCart.Items.Add(product);
            Console.Clear();
            Console.WriteLine(product.Name + " added to shopping cart");
            Console.ReadKey();
            DatabasManager db = new DatabasManager();
            Console.WriteLine("Press any key to go back to the main menu");
            Console.ReadKey();
            
        } 

        public void ShowShoppingCart()
        {
            Console.Clear();

          foreach (var item in ShoppingCart.Items)
          {
            Console.WriteLine(item.Name + " " + item.Price + "kr");
            
          }
          Console.ReadKey();
        }

    }
}