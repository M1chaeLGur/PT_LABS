using System;
using System.Dynamic;
using ProductMainClass;
namespace MeatProduct
{
    public class Meat : Product, IDiscountable
    {
        public int ExpirationDate{get;set;}
        public string Type{get;set;}

        public Meat(string productname, int RPK, int PIK, bool Veg, int ED, string type) : base( productname, RPK, PIK, Veg)
        {
            ExpirationDate = ED;
            Type= type;
        }

        public double GetDiscount()
        {
            return 0.10;
        }
    }

}