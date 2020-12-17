using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using InventoryApp.DAL.Entities;
using InventoryApp.DAL.Operations;

namespace InventoryApp.BLL
{
    class ProductExpiryDatesBLL
    {
        public static Nullable<DateTime> GetNearestProductExpiryDate(Nullable<int> ProductID)
        {
            Nullable<DateTime> NearestExpiryDate = new Nullable<DateTime>();
            NearestExpiryDate = ProductExpiryDatesOP.GetNearestProductExpiryDate(ProductID).PRODUCT_EXPIRY_DATE;
            return NearestExpiryDate;
        }
    }
}
