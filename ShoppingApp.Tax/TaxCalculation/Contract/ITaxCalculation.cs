namespace ShoppingApp.Tax.TaxCalculation.Contract
{
    public interface ITaxCalculation
    {
        /// <summary>
        /// Calculates Tax for a Product Item where Tax Cost is the Sum of Sales 
        /// Tax and Imported Duty of a Product.
        /// </summary>
        /// <param name="price"></param>
        /// <param name="tax"></param>
        /// <param name="imported"></param>
        /// <returns></returns>
        double CalculateTax(double price, double tax, bool imported);
    }
}
