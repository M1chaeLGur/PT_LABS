using System.Runtime.Intrinsics.Arm;
using System.Dynamic;
using ProductMainClass;
namespace BeansProduct
{
    public class Beans : Product, IDiscountable
    {
        public bool IsCanned{get;set;}
        public string Type{get;set;}

        public Beans(string productname, int RPK, int PIK, bool Veg, bool canned, string type) : base( productname, RPK, PIK, Veg)
        {
            IsCanned = canned;
            Type= type;
        }

        public double GetDiscount()
        {
            return 0.10;
        }
    }
}