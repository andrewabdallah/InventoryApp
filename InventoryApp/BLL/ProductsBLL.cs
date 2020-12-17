using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using InventoryApp.DAL.Entities;
using InventoryApp.DAL.Operations;

namespace InventoryApp.BLL
{
    class ProductsBLL
    {
        public static Products CheckProductCodeExistance(string ProductCode)
        {
            return ProductsOP.GetProduct(ProductCode);
        }
    }
}
