using ShoppingApp.Tax.TaxCalculation.Contract;

namespace ShoppingApp.Tax.TaxCalculation
{
    public class CalculateTax : ITaxCalculation
    {
        double ITaxCalculation.CalculateTax(double price, double tax, bool imported)
        {
            double calculatedtax = price * tax;

            if (imported)
                tax += (price * 0.5);

            return tax;
        }
    }
}
