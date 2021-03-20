using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sales_System;

namespace Seller_System
{
    public class Seller
    {
        public string Name;
        public int Age;
        Product[] NewProducts = new Product[3];
        int NewProductsCount = 0;

        public void AddNewProducts(Product NewProduct)
        {
            NewProducts[NewProductsCount] = NewProduct;
            NewProductsCount++;
        }

        public Product Cheapest()
        {
            Product Sale = NewProducts[0];

            for (int i = 1; i < NewProductsCount; i++)
            {
                if (NewProducts[i].Total() < NewProducts[i].Total())
                {
                    Sale = NewProducts[i];
                }
            }
            return Sale;
        }
        public double CalSales()
        {
            double Total = 0;
            {
                for (int i = 0; i < NewProductsCount; i++)
                {
                    double TotalSale = NewProducts[i].Total();
                    Total = Total + TotalSale;
                    Console.WriteLine("Product " + NewProducts[i].NameProduct + ": " + NewProductsCount);
                }
            }
            return Total;
        }
        public double CalAveSales()
        {
            double Avasales = 0;
            {
                for (int i = 0; i < NewProductsCount; i++)
                {
                    double avaragePsale = NewProducts[i].Total();
                    Avasales = Avasales + avaragePsale;
                }
                return Avasales;
            }
        }
        public double Total()
        {
            double Total = 0;
            {
                for (int i = 0; i < NewProductsCount; i++)
                {
                    double TotalS = NewProducts[i].Total();
                    Total = Total + TotalS;
                }
            }
            return Total;
        }
        public Product Expensive()
        {
            Product Sale = NewProducts[0];
            for (int i = 1; i < NewProductsCount; i++)
            {
                if (NewProducts[i].Total() > NewProducts[i].Total())
                {
                    Sale = NewProducts[i];
                }
            }
            return Sale;
        }
    }
}
