using System;

namespace ProductMainClass
{
    public class Product
    {
        public string ProductName{get; set;}
        public int RubPKilo{get;set;}
        public int ProdInKilos{get;set;}
        public bool IsVegetarian{get;set;}


        public Product(string productname, int RPK, int PIK, bool Veg)
        {
            ProductName = productname;
            RubPKilo= RPK;
            ProdInKilos=PIK;
            IsVegetarian= Veg;
        }

        public override string ToString()
        {
            double total = RubPKilo * ProdInKilos;
            string VP = IsVegetarian ? "Вегетарианский продукт" : "Невегетарианский продукт";
            return $"{ProductName}: {RubPKilo} $/кг * {ProdInKilos}кг = {total}";
        }
    }
}

