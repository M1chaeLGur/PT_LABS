using System.Runtime.Intrinsics.Arm;
using System.Dynamic;
using ProductMainClass;
namespace AppleProduct
{
    public class Apple : Product, IDiscountable
    {
        public string Color{get;set;}


        public Apple(string productname, int RPK, int PIK, bool Veg, string color) : base( productname, RPK, PIK, Veg)
        {
            Color = color;

        }
    

    public double GetDiscount()
        {
            return 0.15;
        }
    }    
}