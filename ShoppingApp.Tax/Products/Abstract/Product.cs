using ShoppingApp.Tax.Products.Contracts;
using System;

namespace ShoppingApp.Tax.Products.Abstract
{
    public abstract class Product
    {
        protected string Name { get; set; } = string.Empty;

        private double _price;
        public double Price
        {
            set { _price = value; }
            get { return _price * Quantity; }
        }

        public bool Imported { get; set; }

        public int Quantity { get; set; }

        public Product()
        {
            this.Name = string.Empty;
            this.Price = 0.0;
            this.Imported = false;
            this.Quantity = 0;
        }
        public Product(string name, double price, bool imported, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Imported = imported;
            this.Quantity = quantity;
        }        

        public abstract ProductFactory GetFactory();
    
    }
}
