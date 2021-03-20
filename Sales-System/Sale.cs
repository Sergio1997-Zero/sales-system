using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seller_System;

namespace Sales_System
{
    public class Sale
    {
        
        Seller[] NewSelle = new Seller[3];
        int NewSellerCount = 0;
        public void AddNewSellers(Seller NewSeller)
        {
            NewSelle[NewSellerCount] = NewSeller;
            NewSellerCount++;
        }
        public double Total()
        {
            double Total = 0;
            for (int i = 0; i < NewSellerCount; i++)
            {
                Total = Total + NewSelle[i].Total();
            }
            return Total;
        }
        public Seller Cheapest()
        {
            Seller seller = NewSelle[0];

            for (int i = 1; i < NewSellerCount; i++)
            {
                if (NewSelle[i].Cheapest().Total() < seller.Total())
                {
                    seller = NewSelle[i];
                }
            }
            return seller;
        }
        public double CalAveSales()
        {
            double TotalAvaSales = 0;
            for (int i = 0; i < NewSellerCount; i++)
            {
                TotalAvaSales = TotalAvaSales + NewSelle[i].CalAveSales() / NewSellerCount;
            }
            return TotalAvaSales;
        }
        public Product Expensive()
        {
            Product product = NewSelle[0].Expensive();
            for (int i = 1; i < NewSellerCount; i++)
            {
                if (NewSelle[i].Expensive().Total() > product.Total())
                {
                    product = NewSelle[i].Expensive();
                }
            }
            return product;
        }
    }
}