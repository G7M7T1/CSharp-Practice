using ClassLibrary1;

namespace ExtensionNameSpace
{
    public static class Extension
    {
        public static double GetDiscount(this Product product)
        {
            return product.ProductCost * product.DiscountPercentage / 100;
        }
    }
}