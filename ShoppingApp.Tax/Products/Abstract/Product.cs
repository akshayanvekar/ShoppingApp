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

        public double TaxCost { get; set; }

        public Product(string name, double price, bool imported, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Imported = imported;
            this.Quantity = quantity;
        }

        public override string ToString()
        {
            return (Quantity + " " + ImportedToString(Imported) + " " + Name + " : " + TaxCost);
        }

        public string ImportedToString(bool imported)
        {
            return !imported ? string.Empty : "imported";
        }

        public abstract ProductFactory GetFactory();
    
    }
}
