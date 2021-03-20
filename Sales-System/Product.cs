using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_System
{
    public class Product
    {
        public string NameProduct;
        public double Price;
        internal int price;

        public double Total()
        {
            return price;

        }

    }
}
