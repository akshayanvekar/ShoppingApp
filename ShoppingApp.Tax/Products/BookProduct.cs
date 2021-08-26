using ShoppingApp.Tax.Products.Abstract;
using ShoppingApp.Tax.Products.Contracts;
using ShoppingApp.Tax.Products.Factories;
using ShoppingApp.Tax.Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Tax.Products
{
    public class BookProduct : Product
    {

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
