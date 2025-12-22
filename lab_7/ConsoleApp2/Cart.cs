using System;
using System.Collections.Generic;
using ProductMainClass;

namespace CartOfProducts
{
    public class Cart
    {
        public int MaxAmount{get;set;}

        private List<Product> products;
        public Cart(int maxamount)
        {
          MaxAmount= maxamount;
          products = new List<Product>();  
        }

        public void AddToCart(Product p)
        {
            if (products.Count >= MaxAmount)
            {
                Console.WriteLine("Корзина заполнена, невозможно добавить товар.");
                return;
            }
            products.Add(p);
        }
        public void DeleteFromCart(Product p)
        {
            products.Remove(p);
        }
        public double CalculateTotalCost()
        {
            double sum = 0;

            foreach (var product in products)
            {
            sum += product.RubPKilo * product.ProdInKilos;
            }

            return sum;
        }

        public double CalculateDiscountedCost()
        {
            double sum = 0;

            foreach (var product in products)
            {
            double basePrice = product.RubPKilo * product.ProdInKilos;

            if (product is IDiscountable discountable)
            {
            double discount = discountable.GetDiscount();
            double priceWithDiscount = basePrice * (1 - discount);
            sum += priceWithDiscount;
            }
            else
            {
            sum += basePrice;
            }
            }

            return sum;
        }

        public double CalculateAvgVegCost()
        {
            double sum = 0;
            int count = 0;

            foreach ( var product in products)
            {
                if (product.IsVegetarian)
                {
                    double price = product.RubPKilo * product.ProdInKilos;
                    sum += price;
                    count++;
                }
            }
            if (count==0)
            return 0;
            return sum/ count;
        }

        public static bool operator ==(Cart c1, Cart c2)
        {
            if (ReferenceEquals(c1, c2))
            return true;

            if (c1 is null || c2 is null)
            return false;

            double cost1= c1.CalculateDiscountedCost();
            double cost2= c2.CalculateDiscountedCost();
            return cost1 == cost2;
        }
        public static bool operator !=(Cart c1, Cart c2)
        {
            return !(c1 == c2);
        }


    }
}