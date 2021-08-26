using ShoppingApp.Tax.Products.Abstract;
using System;

namespace ShoppingApp.Tax.Products.Contracts
{
    /// <summary>
    /// Product Factory
    /// </summary>
    public abstract class ProductFactory
    {
        public abstract Product CreateProduct(string name, double price, bool imported, int quantity);
    }
}
