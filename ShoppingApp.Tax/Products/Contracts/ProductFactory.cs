using ShoppingApp.Tax.Products.Abstract;
using System;

namespace ShoppingApp.Tax.Products.Contracts
{
    public abstract class ProductFactory
    {
        public abstract Product CreateProduct(String name, double price, bool imported, int quantity);
    }
}
