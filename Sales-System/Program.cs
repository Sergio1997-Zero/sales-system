using System;
using Sales_System;
using Seller_System;

namespace Sales_sales
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Pc = new Product(); 
            Pc.NameProduct = "Pc";
            Pc.price = 350;
            //////////////////////////////////////////////////////////////////
            Product Airpods = new Product();
            Airpods.NameProduct = "Airpods";
            Airpods.price = 500;
            //////////////////////////////////////////////////////////////////
            Product Mouse = new Product();
            Mouse.NameProduct = "Mouse";
            Mouse.price = 700;
            //////////////////////////////////////////////////////////////////
            Seller Sergio = new Seller();
            Sergio.Name = "Sergio";
            Sergio.Age = 23;
            Sergio.AddNewProducts(Pc);
            //////////////////////////////////////////////////////////////////
            Seller Issabella = new Seller();
            Issabella.Name = "Issabella";
            Issabella.Age = 25;
            Issabella.AddNewProducts(Mouse);
            //////////////////////////////////////////////////////////////////
            Seller Carlos = new Seller();
            Carlos.Name = "Carlos";
            Carlos.Age = 22;
            Carlos.AddNewProducts(Airpods);
            //////////////////////////////////////////////////////////////////
            Sale sales = new Sale();
            sales.AddNewSellers(Sergio);
            sales.AddNewSellers(Issabella);
            sales.AddNewSellers(Carlos);
            //////////////////////////////////////////////////////////////////
            double total = sales.Total();
            Console.WriteLine("Total sales amount: " + total);
            //////////////////////////////////////////////////////////////////
            double Avarge_Sales = sales.CalAveSales();
            Console.WriteLine("Avarage sales: " + Avarge_Sales);
            //////////////////////////////////////////////////////////////////
            Product Expensive_Product = sales.Expensive();
            Console.WriteLine("Most expensive product: " + Expensive_Product.NameProduct + ", Price: " + Expensive_Product.price);
            //////////////////////////////////////////////////////////////////
            Seller cheapest = sales.Cheapest();
            Console.WriteLine("Seller name lowest sell: " + cheapest.Name);
            //////////////////////////////////////////////////////////////////




            Console.ReadKey();

           

        }
    }
}
