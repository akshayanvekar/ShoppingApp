using ShoppingApp.Tax.TaxCalculation.Contract;

namespace ShoppingApp.Tax.TaxCalculation
{
    public class CalculateTax : ITaxCalculation
    {
        private const double ROUND_OFF = 0.05;

        double ITaxCalculation.CalculateTax(double price,
                double tax, bool imported)
        {
            double calculatedtax = price * tax;

            if (imported)
                calculatedtax += (price * 0.5);

            calculatedtax = (int)(calculatedtax / ROUND_OFF + 0.5) * 0.05;

            return calculatedtax;
        }
    }
}
