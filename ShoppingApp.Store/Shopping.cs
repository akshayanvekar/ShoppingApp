using ShoppingApp.Tax.Products.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Store
{
    public class Shopping
    {
        private List<Product> ProductList { get; set; }
        private WareHouse WareHouse;
        public Shopping()
        {
            ProductList = new List<Product>();
            WareHouse = new WareHouse();
        }

        public void Shop()
        {
            AddProducts();

        }

        private void AddProducts()
        {
            bool hasAnyNewProductToAdd = true;

            while (hasAnyNewProductToAdd)
            {
                Console.WriteLine("Enter the product name:\n");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the product price:\n");
                double price = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the quantity:\n");
                int quantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Is product imported or not?(Y/N)\n");
                bool imported = Console.Read() == 'Y';

                Product product = WareHouse.FindProductInWareHouse(name, price, imported, quantity);
                ProductList.Add(product);

                Console.WriteLine("Do you want to add another Product?(Y/N)");
                hasAnyNewProductToAdd = Console.Read() == 'Y';

            }
        }
    }
}