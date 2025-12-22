using System;
using ProductMainClass;
using MeatProduct;
using BeansProduct;
using AppleProduct;
using CartOfProducts;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           Cart cart1 = new Cart(5);
           Cart cart2 = new Cart(5);

           var meat1 = new Meat("Свиной фарш", 5, 2, false, 10, "Свинина");
           var apple1 = new Apple("Белый налив",1, 10, true,"зеленый");
           var beans1 = new Beans("Бондюэль",1 ,1 ,true, true,"Фасоль красная");
           var meat11 = new Meat("Говяжий фарш", 15, 1, false, 5, "Говядина");
           var apple11 = new Apple("Антоновка",1, 2, true,"красный");

           var meat2 = new Meat("Куриный фарш", 3, 1, false, 2, "Курица");
           var apple2 = new Apple("Белый налив",3, 2, true,"зеленый");
           var beans2 = new Beans("Бондюэль",1 ,12 ,true, true,"Фасоль красная");
           var meat21 = new Meat("Куре филиное", 150, 1, false, 14, "Филин");
           var apple21 = new Apple("Антоновка",1, 2, true,"красный");

           cart1.AddToCart(meat1);
           cart1.AddToCart(meat11);
           cart1.AddToCart(apple11);
           cart1.AddToCart(apple1);
           cart1.AddToCart(beans1);

           cart2.AddToCart(meat2);
           cart2.AddToCart(meat21);
           cart2.AddToCart(apple21);
           cart2.AddToCart(apple2);
           cart2.AddToCart(beans2);

           Console.WriteLine(meat1);
           Console.WriteLine(meat11);
           Console.WriteLine(apple1);
           Console.WriteLine(apple11);
           Console.WriteLine(beans1);
           Console.WriteLine();

           Console.WriteLine(meat2);
           Console.WriteLine(meat21);
           Console.WriteLine(apple2);
           Console.WriteLine(apple21);
           Console.WriteLine(beans2);
           Console.WriteLine();

           Console.WriteLine("Итоговая скидка в корзине №1 составит: " + cart1.CalculateDiscountedCost());
           Console.WriteLine("Итоговая скидка в корзине №2 составит: " + cart2.CalculateDiscountedCost());

            if (cart1 == cart2)
            Console.WriteLine("Корзины равны по стоимости со скидкой.");
            else
            Console.WriteLine("Корзины отличаются по стоимости со скидкой.");
        }
    }
}
