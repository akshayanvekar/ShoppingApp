using ShoppingApp.Tax.Products.Abstract;
using ShoppingApp.Tax.Products.Contracts;

namespace ShoppingApp.Tax.Products.Factories
{
    public class BookProductFactory : ProductFactory
    {
        /// <summary>
        /// Create BookProduct Factory
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="imported"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public override Product CreateProduct(string name, double price, bool imported, int quantity)
        {
            return new Products.BookProduct(name, price, imported, quantity);
        }
    }
}
