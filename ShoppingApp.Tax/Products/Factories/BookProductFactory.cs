using ShoppingApp.Tax.Products.Abstract;
using ShoppingApp.Tax.Products.Contracts;

namespace ShoppingApp.Tax.Products.Factories
{
    public class BookProductFactory : ProductFactory
    {
        public override Product CreateProduct(string name, double price, bool imported, int quantity)
        {
            return new Products.BookProduct(name, price, imported, quantity);
        }
    }
}
