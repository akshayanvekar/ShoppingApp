using ShoppingApp.Tax.Products;
using ShoppingApp.Tax.Products.Abstract;
using System.Collections.Generic;

namespace ShoppingApp.Store
{
    /// <summary>
    /// Ware House hold the products and its factory
    /// </summary>
    public class WareHouse
    {
        private readonly Dictionary<string, Product> productItems;
        public WareHouse()
        {
            productItems = new Dictionary<string, Product>
            {
                { "book", new BookProduct() }
            };
        }

        public Product FindProductInWareHouse(string name, double price, bool imported, int quantity)
        {
            Product productItem = productItems[name].GetFactory().CreateProduct(name, price, imported, quantity);
            return productItem;
        }
    }
}
