using ShoppingApp.Tax.Products.Abstract;
using ShoppingApp.Tax.Products.Contracts;
using ShoppingApp.Tax.Products.Factories;
using System;

namespace ShoppingApp.Tax.Products
{
    public class BookProduct : Product
    {
        
        public BookProduct() : base()
        {

        }
        public BookProduct(String name, double price, bool imported, int quantity)
            : base(name, price, imported, quantity)
        {

        }

        public override ProductFactory GetFactory()
        {
            return new BookProductFactory();
        }
    }
}
