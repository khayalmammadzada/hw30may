using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Notebook class yaradın ve aşağıdakı xüsusiyyətləri olsun 
            //- Name - məhsulun adını ifadə edən xüsusiyyət 
            //- BrandName - Notebook -un brand adı 
            //- Price - Notebook -un qiyməti.
            Console.WriteLine("minPrice daxil et");
            int minPrice=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("maxPrice daxil et");
            int maxPrice = Convert.ToInt32(Console.ReadLine());

            Notebook product1 = new Notebook()
            {
                Name = "Yoga",
                BrandName = "Lenovo",
                Price = 1900
            };
            Notebook product2 = new Notebook();
            product2.Name = "Macbook";
            product2.BrandName = "Apple";
            product2.Price = 2500;

            Notebook product3 = new Notebook()
            {
                Name = "Pavilion",
                BrandName = "HP",
                Price = 1400
            };


            Notebook[] products = new Notebook[3];
            products[0] = product1;
            products[1] = product2;
            products[2] = product3;

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Price>minPrice && products[i].Price<maxPrice)
                {
                    Console.WriteLine(products[i].Name);
                }
                
            }
        }
    }
}
  