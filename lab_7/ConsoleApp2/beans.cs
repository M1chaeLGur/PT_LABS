using System.Runtime.Intrinsics.Arm;

namespace BeansProduct
{
    public class Beans : Product
    {
         public int ExpirationDate{get;set;}
        public string Type{get;set;}

        public Beans(string productname, int RPK, int PIK, bool Veg, int ED, string type) : base(string productname, int RPK, int PIK, bool Veg)
        {
            ProductName = productname;
            RubPKilo= RPK;
            ProdInKilos=PIK;
            IsVegetarian= Veg;
            ExpirationDate = ED;
            Type= type;
        }
    }
    
}