using System;
using System.Dynamic;
using ProductMainClass;
namespace MeatProduct
{
    public class Meat : Product
    {
        public int ExpirationDate{get;set;}
        public string Type{get;set;}

        public Meat(string productname, int RPK, int PIK, bool Veg, int ED, string type) : base(string productname, int RPK, int PIK, bool Veg)
        {
            ExpirationDate = ED;
            Type= type;
        }
    }

}